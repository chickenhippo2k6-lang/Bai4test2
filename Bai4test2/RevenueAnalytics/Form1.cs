
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevenueAnalytics
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource? cts;
        private bool dangXuLy;

        public Form1()
        {
            InitializeComponent();

            dtpTuNgay.Value = DateTime.Today.AddDays(-7);
            dtpDenNgay.Value = DateTime.Today;

            cboChiNhanh.Items.AddRange(new object[]
            {
                "Tất cả chi nhánh",
                "Chi nhánh Hà Nội",
                "Chi nhánh TP.HCM",
                "Chi nhánh Đà Nẵng"
            });

            cboChiNhanh.SelectedIndex = 0;

            btnHuy.Enabled = false;

            pgbLoading.Minimum = 0;
            pgbLoading.Maximum = 100;
            pgbLoading.Value = 0;

            dgvRevenueData.ReadOnly = true;
            dgvRevenueData.AllowUserToAddRows = false;
            dgvRevenueData.AllowUserToDeleteRows = false;
            dgvRevenueData.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvRevenueData.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        private async void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dangXuLy)
                return;

            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show(
                    "Từ ngày không được lớn hơn đến ngày!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            dangXuLy = true;
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            btnThongKe.Enabled = false;
            btnHuy.Enabled = true;
            pgbLoading.Value = 0;
            lblProcessingStatus.Text = "Đang chuẩn bị thống kê...";
            dgvRevenueData.DataSource = null;

            string chiNhanh = cboChiNhanh.Text;

            IProgress<int> tienDo = new Progress<int>(phanTram =>
            {
                pgbLoading.Value = Math.Clamp(phanTram, 0, 100);
                lblProcessingStatus.Text =
                    $"Đang thống kê doanh thu... {phanTram}%";
            });

            try
            {
                List<GiaoDich> ketQua = await Task.Run(async () =>
                {
                    var danhSach = new List<GiaoDich>();

                    string[] cacChiNhanh =
                    {
                        "Chi nhánh Hà Nội",
                        "Chi nhánh TP.HCM",
                        "Chi nhánh Đà Nẵng"
                    };

                    Random random = new Random();
                    int soBuoc = 100;
                    int soNgay = (denNgay - tuNgay).Days + 1;

                    for (int i = 1; i <= soBuoc; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        await Task.Delay(45, token);

                        string chiNhanhGD =
                            cacChiNhanh[random.Next(cacChiNhanh.Length)];

                        if (chiNhanh == "Tất cả chi nhánh" ||
                            chiNhanh == chiNhanhGD)
                        {
                            danhSach.Add(new GiaoDich
                            {
                                MaGiaoDich = "GD" + i.ToString("D4"),
                                NgayGiaoDich = tuNgay.AddDays(
                                    random.Next(soNgay)),
                                ChiNhanh = chiNhanhGD,
                                DoanhThu = random.Next(100000, 5000001)
                            });
                        }

                        tienDo.Report(i);
                    }

                    token.ThrowIfCancellationRequested();

                    return danhSach;
                }, token);

                dgvRevenueData.DataSource = ketQua;

                dgvRevenueData.Columns["MaGiaoDich"]!.HeaderText =
                    "Mã giao dịch";

                dgvRevenueData.Columns["NgayGiaoDich"]!.HeaderText =
                    "Ngày giao dịch";

                dgvRevenueData.Columns["NgayGiaoDich"]!
                    .DefaultCellStyle.Format = "dd/MM/yyyy";

                dgvRevenueData.Columns["ChiNhanh"]!.HeaderText =
                    "Chi nhánh";

                dgvRevenueData.Columns["DoanhThu"]!.HeaderText =
                    "Doanh thu (VNĐ)";

                dgvRevenueData.Columns["DoanhThu"]!
                    .DefaultCellStyle.Format = "N0";

                decimal tongDoanhThu = 0;

                foreach (GiaoDich gd in ketQua)
                    tongDoanhThu += gd.DoanhThu;

                pgbLoading.Value = 100;

                lblProcessingStatus.Text =
                    $"Hoàn tất: {ketQua.Count} giao dịch | " +
                    $"Tổng doanh thu: {tongDoanhThu:N0} VNĐ";

                MessageBox.Show(
                    "Thống kê doanh thu thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                pgbLoading.Value = 0;
                lblProcessingStatus.Text = "Đã hủy thao tác!";

                MessageBox.Show(
                    "Đã hủy thao tác!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblProcessingStatus.Text = "Có lỗi xảy ra.";

                MessageBox.Show(
                    "Lỗi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                cts?.Dispose();
                cts = null;

                dangXuLy = false;
                btnThongKe.Enabled = true;
                btnHuy.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dangXuLy && cts != null)
            {
                btnHuy.Enabled = false;
                lblProcessingStatus.Text = "Đang hủy thao tác...";
                cts.Cancel();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class GiaoDich
    {
        public string MaGiaoDich { get; set; } = "";
        public DateTime NgayGiaoDich { get; set; }
        public string ChiNhanh { get; set; } = "";
        public decimal DoanhThu { get; set; }
    }
}
