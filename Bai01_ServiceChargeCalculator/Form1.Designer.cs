namespace Bai01_ServiceChargeCalculator
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
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblSoLuongKhach = new Label();
            txtSoLuongKhach = new TextBox();
            lblGiamGia = new Label();
            txtGiamGia = new TextBox();
            lblTongTienLabel = new Label();
            lblTongTien = new Label();
            btnTinhTien = new Button();
            btnLamMoi = new Button();
            SuspendLayout();
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(30, 30);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(116, 20);
            lblDonGia.TabIndex = 6;
            lblDonGia.Text = "Đơn giá dịch vụ:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(170, 27);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(250, 27);
            txtDonGia.TabIndex = 0;
            // 
            // lblSoLuongKhach
            // 
            lblSoLuongKhach.AutoSize = true;
            lblSoLuongKhach.Location = new Point(30, 75);
            lblSoLuongKhach.Name = "lblSoLuongKhach";
            lblSoLuongKhach.Size = new Size(114, 20);
            lblSoLuongKhach.TabIndex = 7;
            lblSoLuongKhach.Text = "Số lượng khách:";
            // 
            // txtSoLuongKhach
            // 
            txtSoLuongKhach.Location = new Point(170, 72);
            txtSoLuongKhach.Name = "txtSoLuongKhach";
            txtSoLuongKhach.Size = new Size(250, 27);
            txtSoLuongKhach.TabIndex = 1;
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Location = new Point(30, 120);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(99, 20);
            lblGiamGia.TabIndex = 8;
            lblGiamGia.Text = "Mã giảm (%):";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(170, 117);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(250, 27);
            txtGiamGia.TabIndex = 2;
            // 
            // lblTongTienLabel
            // 
            lblTongTienLabel.AutoSize = true;
            lblTongTienLabel.Location = new Point(30, 165);
            lblTongTienLabel.Name = "lblTongTienLabel";
            lblTongTienLabel.Size = new Size(75, 20);
            lblTongTienLabel.TabIndex = 9;
            lblTongTienLabel.Text = "Tổng tiền:";
            // 
            // lblTongTien
            // 
            lblTongTien.BorderStyle = BorderStyle.Fixed3D;
            lblTongTien.Location = new Point(170, 162);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(250, 27);
            lblTongTien.TabIndex = 5;
            lblTongTien.Text = "0";
            lblTongTien.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(170, 210);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(110, 32);
            btnTinhTien.TabIndex = 3;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(310, 210);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 32);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 270);
            Controls.Add(btnLamMoi);
            Controls.Add(btnTinhTien);
            Controls.Add(lblTongTien);
            Controls.Add(lblTongTienLabel);
            Controls.Add(txtGiamGia);
            Controls.Add(lblGiamGia);
            Controls.Add(txtSoLuongKhach);
            Controls.Add(lblSoLuongKhach);
            Controls.Add(txtDonGia);
            Controls.Add(lblDonGia);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 1 - Máy tính tính cước dịch vụ & Giảm giá";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDonGia;
        private TextBox txtDonGia;
        private Label lblSoLuongKhach;
        private TextBox txtSoLuongKhach;
        private Label lblGiamGia;
        private TextBox txtGiamGia;
        private Label lblTongTienLabel;
        private Label lblTongTien;
        private Button btnTinhTien;
        private Button btnLamMoi;
    }
}
