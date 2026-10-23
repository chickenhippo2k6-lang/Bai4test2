
namespace RevenueAnalytics
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;

        private System.Windows.Forms.TableLayoutPanel layoutMain = null!;
        private System.Windows.Forms.TableLayoutPanel layoutTieuChi = null!;
        private System.Windows.Forms.FlowLayoutPanel flowButtons = null!;

        private System.Windows.Forms.Label lblTieuDe = null!;
        private System.Windows.Forms.Label lblTuNgay = null!;
        private System.Windows.Forms.Label lblDenNgay = null!;
        private System.Windows.Forms.Label lblChiNhanh = null!;
        private System.Windows.Forms.Label lblProcessingStatus = null!;

        private System.Windows.Forms.DateTimePicker dtpTuNgay = null!;
        private System.Windows.Forms.DateTimePicker dtpDenNgay = null!;
        private System.Windows.Forms.ComboBox cboChiNhanh = null!;

        private System.Windows.Forms.Button btnThongKe = null!;
        private System.Windows.Forms.Button btnHuy = null!;
        private System.Windows.Forms.Button btnDong = null!;

        private System.Windows.Forms.ProgressBar pgbLoading = null!;
        private System.Windows.Forms.DataGridView dgvRevenueData = null!;

        private System.Windows.Forms.GroupBox grpTieuChi = null!;
        private System.Windows.Forms.GroupBox grpTrangThai = null!;
        private System.Windows.Forms.GroupBox grpKetQua = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            layoutMain = new TableLayoutPanel();
            lblTieuDe = new Label();
            grpTieuChi = new GroupBox();
            layoutTieuChi = new TableLayoutPanel();
            lblTuNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            lblDenNgay = new Label();
            dtpDenNgay = new DateTimePicker();
            lblChiNhanh = new Label();
            cboChiNhanh = new ComboBox();
            flowButtons = new FlowLayoutPanel();
            btnThongKe = new Button();
            btnHuy = new Button();
            btnDong = new Button();
            grpTrangThai = new GroupBox();
            lblProcessingStatus = new Label();
            pgbLoading = new ProgressBar();
            grpKetQua = new GroupBox();
            dgvRevenueData = new DataGridView();
            layoutMain.SuspendLayout();
            grpTieuChi.SuspendLayout();
            layoutTieuChi.SuspendLayout();
            flowButtons.SuspendLayout();
            grpTrangThai.SuspendLayout();
            grpKetQua.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).BeginInit();
            SuspendLayout();
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 1;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutMain.Controls.Add(lblTieuDe, 0, 0);
            layoutMain.Controls.Add(grpTieuChi, 0, 1);
            layoutMain.Controls.Add(grpTrangThai, 0, 2);
            layoutMain.Controls.Add(grpKetQua, 0, 3);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Name = "layoutMain";
            layoutMain.Padding = new Padding(12);
            layoutMain.RowCount = 4;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 165F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMain.Size = new Size(1050, 700);
            layoutMain.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Dock = DockStyle.Fill;
            lblTieuDe.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblTieuDe.Location = new Point(15, 12);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1020, 65);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "BẢNG ĐIỀU KHIỂN THỐNG KÊ DOANH THU";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpTieuChi
            // 
            grpTieuChi.Controls.Add(layoutTieuChi);
            grpTieuChi.Dock = DockStyle.Fill;
            grpTieuChi.Location = new Point(15, 80);
            grpTieuChi.Name = "grpTieuChi";
            grpTieuChi.Padding = new Padding(10);
            grpTieuChi.Size = new Size(1020, 159);
            grpTieuChi.TabIndex = 1;
            grpTieuChi.TabStop = false;
            grpTieuChi.Text = "TIÊU CHÍ THỐNG KÊ";
            // 
            // layoutTieuChi
            // 
            layoutTieuChi.ColumnCount = 4;
            layoutTieuChi.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            layoutTieuChi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutTieuChi.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 85F));
            layoutTieuChi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutTieuChi.Controls.Add(lblTuNgay, 0, 0);
            layoutTieuChi.Controls.Add(dtpTuNgay, 1, 0);
            layoutTieuChi.Controls.Add(lblDenNgay, 2, 0);
            layoutTieuChi.Controls.Add(dtpDenNgay, 3, 0);
            layoutTieuChi.Controls.Add(lblChiNhanh, 0, 1);
            layoutTieuChi.Controls.Add(cboChiNhanh, 1, 1);
            layoutTieuChi.Controls.Add(flowButtons, 2, 1);
            layoutTieuChi.Dock = DockStyle.Fill;
            layoutTieuChi.Location = new Point(10, 30);
            layoutTieuChi.Name = "layoutTieuChi";
            layoutTieuChi.RowCount = 2;
            layoutTieuChi.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            layoutTieuChi.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            layoutTieuChi.Size = new Size(1000, 119);
            layoutTieuChi.TabIndex = 0;
            // 
            // lblTuNgay
            // 
            lblTuNgay.Dock = DockStyle.Fill;
            lblTuNgay.Location = new Point(3, 0);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(79, 42);
            lblTuNgay.TabIndex = 0;
            lblTuNgay.Text = "Từ ngày:";
            lblTuNgay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Dock = DockStyle.Fill;
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(88, 3);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(409, 27);
            dtpTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            lblDenNgay.Dock = DockStyle.Fill;
            lblDenNgay.Location = new Point(503, 0);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(79, 42);
            lblDenNgay.TabIndex = 2;
            lblDenNgay.Text = "Đến ngày:";
            lblDenNgay.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Dock = DockStyle.Fill;
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(588, 3);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(409, 27);
            dtpDenNgay.TabIndex = 3;
            // 
            // lblChiNhanh
            // 
            lblChiNhanh.Dock = DockStyle.Fill;
            lblChiNhanh.Location = new Point(3, 42);
            lblChiNhanh.Name = "lblChiNhanh";
            lblChiNhanh.Size = new Size(79, 77);
            lblChiNhanh.TabIndex = 4;
            lblChiNhanh.Text = "Chi nhánh:";
            lblChiNhanh.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboChiNhanh
            // 
            cboChiNhanh.Dock = DockStyle.Fill;
            cboChiNhanh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChiNhanh.Location = new Point(88, 45);
            cboChiNhanh.Name = "cboChiNhanh";
            cboChiNhanh.Size = new Size(409, 28);
            cboChiNhanh.TabIndex = 5;
            // 
            // flowButtons
            // 
            flowButtons.AutoScroll = true;
            layoutTieuChi.SetColumnSpan(flowButtons, 2);
            flowButtons.Controls.Add(btnThongKe);
            flowButtons.Controls.Add(btnHuy);
            flowButtons.Controls.Add(btnDong);
            flowButtons.Dock = DockStyle.Fill;
            flowButtons.Location = new Point(503, 45);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(494, 71);
            flowButtons.TabIndex = 6;
            flowButtons.WrapContents = false;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(3, 3);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(175, 35);
            btnThongKe.TabIndex = 0;
            btnThongKe.Text = "Thống Kê Doanh Thu";
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(184, 3);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(115, 35);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Hủy Thao Tác";
            btnHuy.Click += btnHuy_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(305, 3);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(75, 35);
            btnDong.TabIndex = 2;
            btnDong.Text = "Đóng";
            btnDong.Click += btnDong_Click;
            // 
            // grpTrangThai
            // 
            grpTrangThai.Controls.Add(lblProcessingStatus);
            grpTrangThai.Controls.Add(pgbLoading);
            grpTrangThai.Dock = DockStyle.Fill;
            grpTrangThai.Location = new Point(15, 245);
            grpTrangThai.Name = "grpTrangThai";
            grpTrangThai.Padding = new Padding(10);
            grpTrangThai.Size = new Size(1020, 94);
            grpTrangThai.TabIndex = 2;
            grpTrangThai.TabStop = false;
            grpTrangThai.Text = "TRẠNG THÁI XỬ LÝ";
            // 
            // lblProcessingStatus
            // 
            lblProcessingStatus.AutoEllipsis = true;
            lblProcessingStatus.Dock = DockStyle.Fill;
            lblProcessingStatus.Location = new Point(10, 55);
            lblProcessingStatus.Name = "lblProcessingStatus";
            lblProcessingStatus.Size = new Size(1000, 29);
            lblProcessingStatus.TabIndex = 0;
            lblProcessingStatus.Text = "Sẵn sàng thống kê doanh thu.";
            lblProcessingStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pgbLoading
            // 
            pgbLoading.Dock = DockStyle.Top;
            pgbLoading.Location = new Point(10, 30);
            pgbLoading.Name = "pgbLoading";
            pgbLoading.Size = new Size(1000, 25);
            pgbLoading.Style = ProgressBarStyle.Continuous;
            pgbLoading.TabIndex = 1;
            // 
            // grpKetQua
            // 
            grpKetQua.Controls.Add(dgvRevenueData);
            grpKetQua.Dock = DockStyle.Fill;
            grpKetQua.Location = new Point(15, 345);
            grpKetQua.Name = "grpKetQua";
            grpKetQua.Padding = new Padding(8);
            grpKetQua.Size = new Size(1020, 340);
            grpKetQua.TabIndex = 3;
            grpKetQua.TabStop = false;
            grpKetQua.Text = "CHI TIẾT GIAO DỊCH";
            // 
            // dgvRevenueData
            // 
            dgvRevenueData.AllowUserToAddRows = false;
            dgvRevenueData.AllowUserToDeleteRows = false;
            dgvRevenueData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRevenueData.BackgroundColor = Color.White;
            dgvRevenueData.ColumnHeadersHeight = 29;
            dgvRevenueData.Dock = DockStyle.Fill;
            dgvRevenueData.Location = new Point(8, 28);
            dgvRevenueData.Name = "dgvRevenueData";
            dgvRevenueData.ReadOnly = true;
            dgvRevenueData.RowHeadersVisible = false;
            dgvRevenueData.RowHeadersWidth = 51;
            dgvRevenueData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRevenueData.Size = new Size(1004, 304);
            dgvRevenueData.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 700);
            Controls.Add(layoutMain);
            MinimumSize = new Size(850, 560);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng điều khiển thống kê doanh thu";
            layoutMain.ResumeLayout(false);
            grpTieuChi.ResumeLayout(false);
            layoutTieuChi.ResumeLayout(false);
            flowButtons.ResumeLayout(false);
            grpTrangThai.ResumeLayout(false);
            grpKetQua.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).EndInit();
            ResumeLayout(false);
        }
    }
}
