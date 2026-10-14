namespace Bai02_ITSupportTicket
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
            lblMaPhieu = new Label();
            txtMaPhieu = new TextBox();
            lblNguoiYeuCau = new Label();
            txtNguoiYeuCau = new TextBox();
            lblNgayGhiNhan = new Label();
            dtpNgayGhiNhan = new DateTimePicker();
            lblMucDoUuTien = new Label();
            pnlMucDoUuTien = new Panel();
            rdoKhanCap = new RadioButton();
            rdoTrungBinh = new RadioButton();
            rdoThap = new RadioButton();
            lblLoaiSuCo = new Label();
            cboLoaiSuCo = new ComboBox();
            lblThietBi = new Label();
            pnlThietBi = new Panel();
            chkDienThoai = new CheckBox();
            chkMayIn = new CheckBox();
            chkLaptop = new CheckBox();
            chkMayTinhBan = new CheckBox();
            lblAnhLoi = new Label();
            picAnhLoi = new PictureBox();
            btnTaiAnh = new Button();
            btnGuiYeuCau = new Button();
            btnNhapLai = new Button();
            pnlMucDoUuTien.SuspendLayout();
            pnlThietBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).BeginInit();
            SuspendLayout();
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.AutoSize = true;
            lblMaPhieu.Location = new Point(30, 25);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(74, 20);
            lblMaPhieu.TabIndex = 11;
            lblMaPhieu.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Location = new Point(170, 22);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(410, 27);
            txtMaPhieu.TabIndex = 0;
            // 
            // lblNguoiYeuCau
            // 
            lblNguoiYeuCau.AutoSize = true;
            lblNguoiYeuCau.Location = new Point(30, 65);
            lblNguoiYeuCau.Name = "lblNguoiYeuCau";
            lblNguoiYeuCau.Size = new Size(107, 20);
            lblNguoiYeuCau.TabIndex = 12;
            lblNguoiYeuCau.Text = "Người yêu cầu:";
            // 
            // txtNguoiYeuCau
            // 
            txtNguoiYeuCau.Location = new Point(170, 62);
            txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            txtNguoiYeuCau.Size = new Size(410, 27);
            txtNguoiYeuCau.TabIndex = 1;
            // 
            // lblNgayGhiNhan
            // 
            lblNgayGhiNhan.AutoSize = true;
            lblNgayGhiNhan.Location = new Point(30, 105);
            lblNgayGhiNhan.Name = "lblNgayGhiNhan";
            lblNgayGhiNhan.Size = new Size(109, 20);
            lblNgayGhiNhan.TabIndex = 13;
            lblNgayGhiNhan.Text = "Ngày ghi nhận:";
            // 
            // dtpNgayGhiNhan
            // 
            dtpNgayGhiNhan.CustomFormat = "dd/MM/yyyy";
            dtpNgayGhiNhan.Format = DateTimePickerFormat.Custom;
            dtpNgayGhiNhan.Location = new Point(170, 102);
            dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            dtpNgayGhiNhan.Size = new Size(410, 27);
            dtpNgayGhiNhan.TabIndex = 2;
            // 
            // lblMucDoUuTien
            // 
            lblMucDoUuTien.AutoSize = true;
            lblMucDoUuTien.Location = new Point(30, 145);
            lblMucDoUuTien.Name = "lblMucDoUuTien";
            lblMucDoUuTien.Size = new Size(111, 20);
            lblMucDoUuTien.TabIndex = 14;
            lblMucDoUuTien.Text = "Mức độ ưu tiên:";
            // 
            // pnlMucDoUuTien
            // 
            pnlMucDoUuTien.Controls.Add(rdoKhanCap);
            pnlMucDoUuTien.Controls.Add(rdoTrungBinh);
            pnlMucDoUuTien.Controls.Add(rdoThap);
            pnlMucDoUuTien.Location = new Point(170, 140);
            pnlMucDoUuTien.Name = "pnlMucDoUuTien";
            pnlMucDoUuTien.Size = new Size(410, 32);
            pnlMucDoUuTien.TabIndex = 3;
            // 
            // rdoKhanCap
            // 
            rdoKhanCap.AutoSize = true;
            rdoKhanCap.Location = new Point(230, 4);
            rdoKhanCap.Name = "rdoKhanCap";
            rdoKhanCap.Size = new Size(91, 24);
            rdoKhanCap.TabIndex = 2;
            rdoKhanCap.Text = "Khẩn cấp";
            rdoKhanCap.UseVisualStyleBackColor = true;
            // 
            // rdoTrungBinh
            // 
            rdoTrungBinh.AutoSize = true;
            rdoTrungBinh.Checked = true;
            rdoTrungBinh.Location = new Point(105, 4);
            rdoTrungBinh.Name = "rdoTrungBinh";
            rdoTrungBinh.Size = new Size(100, 24);
            rdoTrungBinh.TabIndex = 1;
            rdoTrungBinh.TabStop = true;
            rdoTrungBinh.Text = "Trung bình";
            rdoTrungBinh.UseVisualStyleBackColor = true;
            // 
            // rdoThap
            // 
            rdoThap.AutoSize = true;
            rdoThap.Location = new Point(5, 4);
            rdoThap.Name = "rdoThap";
            rdoThap.Size = new Size(62, 24);
            rdoThap.TabIndex = 0;
            rdoThap.Text = "Thấp";
            rdoThap.UseVisualStyleBackColor = true;
            // 
            // lblLoaiSuCo
            // 
            lblLoaiSuCo.AutoSize = true;
            lblLoaiSuCo.Location = new Point(30, 185);
            lblLoaiSuCo.Name = "lblLoaiSuCo";
            lblLoaiSuCo.Size = new Size(80, 20);
            lblLoaiSuCo.TabIndex = 15;
            lblLoaiSuCo.Text = "Loại sự cố:";
            // 
            // cboLoaiSuCo
            // 
            cboLoaiSuCo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiSuCo.FormattingEnabled = true;
            cboLoaiSuCo.Location = new Point(170, 182);
            cboLoaiSuCo.Name = "cboLoaiSuCo";
            cboLoaiSuCo.Size = new Size(410, 28);
            cboLoaiSuCo.TabIndex = 4;
            // 
            // lblThietBi
            // 
            lblThietBi.AutoSize = true;
            lblThietBi.Location = new Point(30, 225);
            lblThietBi.Name = "lblThietBi";
            lblThietBi.Size = new Size(130, 20);
            lblThietBi.TabIndex = 16;
            lblThietBi.Text = "Thiết bị ảnh hưởng:";
            // 
            // pnlThietBi
            // 
            pnlThietBi.Controls.Add(chkDienThoai);
            pnlThietBi.Controls.Add(chkMayIn);
            pnlThietBi.Controls.Add(chkLaptop);
            pnlThietBi.Controls.Add(chkMayTinhBan);
            pnlThietBi.Location = new Point(170, 220);
            pnlThietBi.Name = "pnlThietBi";
            pnlThietBi.Size = new Size(410, 32);
            pnlThietBi.TabIndex = 5;
            // 
            // chkDienThoai
            // 
            chkDienThoai.AutoSize = true;
            chkDienThoai.Location = new Point(310, 4);
            chkDienThoai.Name = "chkDienThoai";
            chkDienThoai.Size = new Size(100, 24);
            chkDienThoai.TabIndex = 3;
            chkDienThoai.Text = "Điện thoại";
            chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // chkMayIn
            // 
            chkMayIn.AutoSize = true;
            chkMayIn.Location = new Point(220, 4);
            chkMayIn.Name = "chkMayIn";
            chkMayIn.Size = new Size(76, 24);
            chkMayIn.TabIndex = 2;
            chkMayIn.Text = "Máy in";
            chkMayIn.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            chkLaptop.AutoSize = true;
            chkLaptop.Location = new Point(130, 4);
            chkLaptop.Name = "chkLaptop";
            chkLaptop.Size = new Size(78, 24);
            chkLaptop.TabIndex = 1;
            chkLaptop.Text = "Laptop";
            chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkMayTinhBan
            // 
            chkMayTinhBan.AutoSize = true;
            chkMayTinhBan.Location = new Point(5, 4);
            chkMayTinhBan.Name = "chkMayTinhBan";
            chkMayTinhBan.Size = new Size(117, 24);
            chkMayTinhBan.TabIndex = 0;
            chkMayTinhBan.Text = "Máy tính bàn";
            chkMayTinhBan.UseVisualStyleBackColor = true;
            // 
            // lblAnhLoi
            // 
            lblAnhLoi.AutoSize = true;
            lblAnhLoi.Location = new Point(30, 265);
            lblAnhLoi.Name = "lblAnhLoi";
            lblAnhLoi.Size = new Size(95, 20);
            lblAnhLoi.TabIndex = 17;
            lblAnhLoi.Text = "Ảnh chụp lỗi:";
            // 
            // picAnhLoi
            // 
            picAnhLoi.BorderStyle = BorderStyle.FixedSingle;
            picAnhLoi.Location = new Point(170, 265);
            picAnhLoi.Name = "picAnhLoi";
            picAnhLoi.Size = new Size(150, 110);
            picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhLoi.TabIndex = 18;
            picAnhLoi.TabStop = false;
            // 
            // btnTaiAnh
            // 
            btnTaiAnh.Location = new Point(335, 343);
            btnTaiAnh.Name = "btnTaiAnh";
            btnTaiAnh.Size = new Size(100, 32);
            btnTaiAnh.TabIndex = 6;
            btnTaiAnh.Text = "Tải ảnh lỗi";
            btnTaiAnh.UseVisualStyleBackColor = true;
            btnTaiAnh.Click += btnTaiAnh_Click;
            // 
            // btnGuiYeuCau
            // 
            btnGuiYeuCau.Location = new Point(170, 395);
            btnGuiYeuCau.Name = "btnGuiYeuCau";
            btnGuiYeuCau.Size = new Size(110, 34);
            btnGuiYeuCau.TabIndex = 7;
            btnGuiYeuCau.Text = "Gửi yêu cầu";
            btnGuiYeuCau.UseVisualStyleBackColor = true;
            btnGuiYeuCau.Click += btnGuiYeuCau_Click;
            // 
            // btnNhapLai
            // 
            btnNhapLai.Location = new Point(300, 395);
            btnNhapLai.Name = "btnNhapLai";
            btnNhapLai.Size = new Size(110, 34);
            btnNhapLai.TabIndex = 8;
            btnNhapLai.Text = "Nhập lại";
            btnNhapLai.UseVisualStyleBackColor = true;
            btnNhapLai.Click += btnNhapLai_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 450);
            Controls.Add(btnNhapLai);
            Controls.Add(btnGuiYeuCau);
            Controls.Add(btnTaiAnh);
            Controls.Add(picAnhLoi);
            Controls.Add(lblAnhLoi);
            Controls.Add(pnlThietBi);
            Controls.Add(lblThietBi);
            Controls.Add(cboLoaiSuCo);
            Controls.Add(lblLoaiSuCo);
            Controls.Add(pnlMucDoUuTien);
            Controls.Add(lblMucDoUuTien);
            Controls.Add(dtpNgayGhiNhan);
            Controls.Add(lblNgayGhiNhan);
            Controls.Add(txtNguoiYeuCau);
            Controls.Add(lblNguoiYeuCau);
            Controls.Add(txtMaPhieu);
            Controls.Add(lblMaPhieu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 2 - Form Tiếp nhận & Phân loại sự cố IT";
            Load += Form1_Load;
            pnlMucDoUuTien.ResumeLayout(false);
            pnlMucDoUuTien.PerformLayout();
            pnlThietBi.ResumeLayout(false);
            pnlThietBi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnhLoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaPhieu;
        private TextBox txtMaPhieu;
        private Label lblNguoiYeuCau;
        private TextBox txtNguoiYeuCau;
        private Label lblNgayGhiNhan;
        private DateTimePicker dtpNgayGhiNhan;
        private Label lblMucDoUuTien;
        private Panel pnlMucDoUuTien;
        private RadioButton rdoKhanCap;
        private RadioButton rdoTrungBinh;
        private RadioButton rdoThap;
        private Label lblLoaiSuCo;
        private ComboBox cboLoaiSuCo;
        private Label lblThietBi;
        private Panel pnlThietBi;
        private CheckBox chkDienThoai;
        private CheckBox chkMayIn;
        private CheckBox chkLaptop;
        private CheckBox chkMayTinhBan;
        private Label lblAnhLoi;
        private PictureBox picAnhLoi;
        private Button btnTaiAnh;
        private Button btnGuiYeuCau;
        private Button btnNhapLai;
    }
}
