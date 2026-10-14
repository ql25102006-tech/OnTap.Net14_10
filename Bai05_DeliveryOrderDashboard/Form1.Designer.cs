namespace Bai05_DeliveryOrderDashboard
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            grpCustomer = new GroupBox();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            rdoGiaoHoaToc = new RadioButton();
            rdoGiaoTietKiem = new RadioButton();
            rdoGiaoNhanh = new RadioButton();
            lblLoaiVanChuyen = new Label();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            txtTenKhachHang = new TextBox();
            lblTenKhachHang = new Label();
            txtMaDonHang = new TextBox();
            lblMaDonHang = new Label();
            pnlGridHeader = new Panel();
            btnXoaDong = new Button();
            btnThemDong = new Button();
            lblGridTitle = new Label();
            dgvItems = new DataGridView();
            colTenHang = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colTrongLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            statusStrip1 = new StatusStrip();
            sslThoiGian = new ToolStripStatusLabel();
            sslTongSoLuong = new ToolStripStatusLabel();
            sslTongTrongLuong = new ToolStripStatusLabel();
            sslTongTien = new ToolStripStatusLabel();
            errorProvider1 = new ErrorProvider(components);
            timerClock = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grpCustomer.SuspendLayout();
            pnlGridHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(grpCustomer);
            splitContainer1.Panel1.Padding = new Padding(10, 10, 5, 10);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvItems);
            splitContainer1.Panel2.Controls.Add(pnlGridHeader);
            splitContainer1.Panel2.Padding = new Padding(5, 10, 10, 10);
            splitContainer1.Size = new Size(980, 480);
            splitContainer1.SplitterDistance = 330;
            splitContainer1.TabIndex = 0;
            // 
            // grpCustomer
            // 
            grpCustomer.Controls.Add(txtDiaChi);
            grpCustomer.Controls.Add(lblDiaChi);
            grpCustomer.Controls.Add(rdoGiaoHoaToc);
            grpCustomer.Controls.Add(rdoGiaoTietKiem);
            grpCustomer.Controls.Add(rdoGiaoNhanh);
            grpCustomer.Controls.Add(lblLoaiVanChuyen);
            grpCustomer.Controls.Add(txtSoDienThoai);
            grpCustomer.Controls.Add(lblSoDienThoai);
            grpCustomer.Controls.Add(txtTenKhachHang);
            grpCustomer.Controls.Add(lblTenKhachHang);
            grpCustomer.Controls.Add(txtMaDonHang);
            grpCustomer.Controls.Add(lblMaDonHang);
            grpCustomer.Dock = DockStyle.Fill;
            grpCustomer.Location = new Point(10, 10);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Size = new Size(315, 460);
            grpCustomer.TabIndex = 0;
            grpCustomer.TabStop = false;
            grpCustomer.Text = "Thông tin khách hàng & Vận chuyển";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(15, 215);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(280, 60);
            txtDiaChi.TabIndex = 3;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(15, 190);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(58, 20);
            lblDiaChi.TabIndex = 9;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // rdoGiaoHoaToc
            // 
            rdoGiaoHoaToc.AutoSize = true;
            rdoGiaoHoaToc.Location = new Point(20, 370);
            rdoGiaoHoaToc.Name = "rdoGiaoHoaToc";
            rdoGiaoHoaToc.Size = new Size(149, 24);
            rdoGiaoHoaToc.TabIndex = 6;
            rdoGiaoHoaToc.Text = "Hỏa tốc (2 - 4 giờ)";
            rdoGiaoHoaToc.UseVisualStyleBackColor = true;
            // 
            // rdoGiaoTietKiem
            // 
            rdoGiaoTietKiem.AutoSize = true;
            rdoGiaoTietKiem.Location = new Point(20, 340);
            rdoGiaoTietKiem.Name = "rdoGiaoTietKiem";
            rdoGiaoTietKiem.Size = new Size(160, 24);
            rdoGiaoTietKiem.TabIndex = 5;
            rdoGiaoTietKiem.Text = "Tiết kiệm (3 - 5 ngày)";
            rdoGiaoTietKiem.UseVisualStyleBackColor = true;
            // 
            // rdoGiaoNhanh
            // 
            rdoGiaoNhanh.AutoSize = true;
            rdoGiaoNhanh.Checked = true;
            rdoGiaoNhanh.Location = new Point(20, 310);
            rdoGiaoNhanh.Name = "rdoGiaoNhanh";
            rdoGiaoNhanh.Size = new Size(157, 24);
            rdoGiaoNhanh.TabIndex = 4;
            rdoGiaoNhanh.TabStop = true;
            rdoGiaoNhanh.Text = "Giao nhanh (24 giờ)";
            rdoGiaoNhanh.UseVisualStyleBackColor = true;
            // 
            // lblLoaiVanChuyen
            // 
            lblLoaiVanChuyen.AutoSize = true;
            lblLoaiVanChuyen.Location = new Point(15, 285);
            lblLoaiVanChuyen.Name = "lblLoaiVanChuyen";
            lblLoaiVanChuyen.Size = new Size(118, 20);
            lblLoaiVanChuyen.TabIndex = 10;
            lblLoaiVanChuyen.Text = "Loại vận chuyển:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(15, 155);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(280, 27);
            txtSoDienThoai.TabIndex = 2;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Location = new Point(15, 130);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(100, 20);
            lblSoDienThoai.TabIndex = 8;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(15, 95);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(280, 27);
            txtTenKhachHang.TabIndex = 1;
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Location = new Point(15, 75);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(114, 20);
            lblTenKhachHang.TabIndex = 7;
            lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // txtMaDonHang
            // 
            txtMaDonHang.Location = new Point(15, 45);
            txtMaDonHang.Name = "txtMaDonHang";
            txtMaDonHang.Size = new Size(280, 27);
            txtMaDonHang.TabIndex = 0;
            // 
            // lblMaDonHang
            // 
            lblMaDonHang.AutoSize = true;
            lblMaDonHang.Location = new Point(15, 25);
            lblMaDonHang.Name = "lblMaDonHang";
            lblMaDonHang.Size = new Size(101, 20);
            lblMaDonHang.TabIndex = 6;
            lblMaDonHang.Text = "Mã đơn hàng:";
            // 
            // pnlGridHeader
            // 
            pnlGridHeader.Controls.Add(btnXoaDong);
            pnlGridHeader.Controls.Add(btnThemDong);
            pnlGridHeader.Controls.Add(lblGridTitle);
            pnlGridHeader.Dock = DockStyle.Top;
            pnlGridHeader.Location = new Point(5, 10);
            pnlGridHeader.Name = "pnlGridHeader";
            pnlGridHeader.Size = new Size(631, 38);
            pnlGridHeader.TabIndex = 0;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXoaDong.Location = new Point(515, 3);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(112, 30);
            btnXoaDong.TabIndex = 2;
            btnXoaDong.Text = "Xóa dòng (Del)";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            // 
            // btnThemDong
            // 
            btnThemDong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemDong.Location = new Point(390, 3);
            btnThemDong.Name = "btnThemDong";
            btnThemDong.Size = new Size(120, 30);
            btnThemDong.TabIndex = 1;
            btnThemDong.Text = "Thêm dòng (F2)";
            btnThemDong.UseVisualStyleBackColor = true;
            btnThemDong.Click += btnThemDong_Click;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGridTitle.Location = new Point(0, 8);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Size = new Size(251, 21);
            lblGridTitle.TabIndex = 0;
            lblGridTitle.Text = "Chi tiết danh mục hàng hóa:";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = true;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colTenHang, colSoLuong, colTrongLuong, colDonGia, colThanhTien });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(5, 48);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 35;
            dgvItems.Size = new Size(631, 422);
            dgvItems.TabIndex = 1;
            dgvItems.CellValueChanged += dgvItems_CellValueChanged;
            dgvItems.RowsRemoved += dgvItems_RowsRemoved;
            // 
            // colTenHang
            // 
            colTenHang.FillWeight = 130F;
            colTenHang.HeaderText = "Tên hàng";
            colTenHang.MinimumWidth = 6;
            colTenHang.Name = "colTenHang";
            // 
            // colSoLuong
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            colSoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            colSoLuong.FillWeight = 70F;
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // colTrongLuong
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            colTrongLuong.DefaultCellStyle = dataGridViewCellStyle2;
            colTrongLuong.FillWeight = 85F;
            colTrongLuong.HeaderText = "Trọng lượng (kg)";
            colTrongLuong.MinimumWidth = 6;
            colTrongLuong.Name = "colTrongLuong";
            // 
            // colDonGia
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            colDonGia.DefaultCellStyle = dataGridViewCellStyle3;
            colDonGia.FillWeight = 90F;
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            colThanhTien.FillWeight = 100F;
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { sslThoiGian, sslTongSoLuong, sslTongTrongLuong, sslTongTien });
            statusStrip1.Location = new Point(0, 480);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(980, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // sslThoiGian
            // 
            sslThoiGian.BorderSides = ToolStripStatusLabelBorderSides.Right;
            sslThoiGian.Name = "sslThoiGian";
            sslThoiGian.Size = new Size(137, 20);
            sslThoiGian.Text = "Thời gian: 00:00:00";
            // 
            // sslTongSoLuong
            // 
            sslTongSoLuong.BorderSides = ToolStripStatusLabelBorderSides.Right;
            sslTongSoLuong.Name = "sslTongSoLuong";
            sslTongSoLuong.Size = new Size(99, 20);
            sslTongSoLuong.Text = "Tổng SL: 0";
            // 
            // sslTongTrongLuong
            // 
            sslTongTrongLuong.BorderSides = ToolStripStatusLabelBorderSides.Right;
            sslTongTrongLuong.Name = "sslTongTrongLuong";
            sslTongTrongLuong.Size = new Size(122, 20);
            sslTongTrongLuong.Text = "Tổng TL: 0.00 kg";
            // 
            // sslTongTien
            // 
            sslTongTien.Name = "sslTongTien";
            sslTongTien.Size = new Size(123, 20);
            sslTongTien.Text = "Tổng tiền: 0 VNĐ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // timerClock
            // 
            timerClock.Enabled = true;
            timerClock.Interval = 1000;
            timerClock.Tick += timerClock_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 506);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            KeyPreview = true;
            MinimumSize = new Size(800, 450);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 5 - Bảng điều khiển Quản lý Đơn giao hàng";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grpCustomer.ResumeLayout(false);
            grpCustomer.PerformLayout();
            pnlGridHeader.ResumeLayout(false);
            pnlGridHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox grpCustomer;
        private Label lblMaDonHang;
        private TextBox txtMaDonHang;
        private Label lblTenKhachHang;
        private TextBox txtTenKhachHang;
        private Label lblSoDienThoai;
        private TextBox txtSoDienThoai;
        private Label lblDiaChi;
        private TextBox txtDiaChi;
        private Label lblLoaiVanChuyen;
        private RadioButton rdoGiaoNhanh;
        private RadioButton rdoGiaoTietKiem;
        private RadioButton rdoGiaoHoaToc;
        private Panel pnlGridHeader;
        private Label lblGridTitle;
        private Button btnThemDong;
        private Button btnXoaDong;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn colTenHang;
        private DataGridViewTextBoxColumn colSoLuong;
        private DataGridViewTextBoxColumn colTrongLuong;
        private DataGridViewTextBoxColumn colDonGia;
        private DataGridViewTextBoxColumn colThanhTien;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel sslThoiGian;
        private ToolStripStatusLabel sslTongSoLuong;
        private ToolStripStatusLabel sslTongTrongLuong;
        private ToolStripStatusLabel sslTongTien;
        private ErrorProvider errorProvider1;
        private System.Windows.Forms.Timer timerClock;
    }
}
