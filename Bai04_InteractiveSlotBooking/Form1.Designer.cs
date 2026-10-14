namespace Bai04_InteractiveSlotBooking
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
            pnlSlotMatrix = new TableLayoutPanel();
            grpInfo = new GroupBox();
            btnHuyChonTatCa = new Button();
            btnXacNhanDat = new Button();
            lblGiaKhungGio = new Label();
            lblTamTinhTien = new Label();
            lblTamTinhTienLabel = new Label();
            lblSoViTriChon = new Label();
            lblSoViTriChonLabel = new Label();
            cboKhungGio = new ComboBox();
            lblKhungGio = new Label();
            pnlLegends = new Panel();
            lblLegendBooked = new Label();
            lblLegendBookedBox = new Label();
            lblLegendSelected = new Label();
            lblLegendSelectedBox = new Label();
            lblLegendEmpty = new Label();
            lblLegendEmptyBox = new Label();
            grpInfo.SuspendLayout();
            pnlLegends.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSlotMatrix
            // 
            pnlSlotMatrix.BorderStyle = BorderStyle.FixedSingle;
            pnlSlotMatrix.ColumnCount = 5;
            pnlSlotMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlSlotMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlSlotMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlSlotMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlSlotMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlSlotMatrix.Location = new Point(15, 15);
            pnlSlotMatrix.Name = "pnlSlotMatrix";
            pnlSlotMatrix.RowCount = 4;
            pnlSlotMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlSlotMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlSlotMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlSlotMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            pnlSlotMatrix.Size = new Size(460, 360);
            pnlSlotMatrix.TabIndex = 0;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(btnHuyChonTatCa);
            grpInfo.Controls.Add(btnXacNhanDat);
            grpInfo.Controls.Add(lblGiaKhungGio);
            grpInfo.Controls.Add(lblTamTinhTien);
            grpInfo.Controls.Add(lblTamTinhTienLabel);
            grpInfo.Controls.Add(lblSoViTriChon);
            grpInfo.Controls.Add(lblSoViTriChonLabel);
            grpInfo.Controls.Add(cboKhungGio);
            grpInfo.Controls.Add(lblKhungGio);
            grpInfo.Location = new Point(490, 15);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(305, 360);
            grpInfo.TabIndex = 1;
            grpInfo.TabStop = false;
            grpInfo.Text = "Thông tin & Thống kê";
            // 
            // btnHuyChonTatCa
            // 
            btnHuyChonTatCa.Location = new Point(20, 295);
            btnHuyChonTatCa.Name = "btnHuyChonTatCa";
            btnHuyChonTatCa.Size = new Size(265, 38);
            btnHuyChonTatCa.TabIndex = 4;
            btnHuyChonTatCa.Text = "Hủy chọn tất cả";
            btnHuyChonTatCa.UseVisualStyleBackColor = true;
            btnHuyChonTatCa.Click += btnHuyChonTatCa_Click;
            // 
            // btnXacNhanDat
            // 
            btnXacNhanDat.Location = new Point(20, 245);
            btnXacNhanDat.Name = "btnXacNhanDat";
            btnXacNhanDat.Size = new Size(265, 38);
            btnXacNhanDat.TabIndex = 3;
            btnXacNhanDat.Text = "Xác nhận đặt";
            btnXacNhanDat.UseVisualStyleBackColor = true;
            btnXacNhanDat.Click += btnXacNhanDat_Click;
            // 
            // lblGiaKhungGio
            // 
            lblGiaKhungGio.AutoSize = true;
            lblGiaKhungGio.Location = new Point(20, 95);
            lblGiaKhungGio.Name = "lblGiaKhungGio";
            lblGiaKhungGio.Size = new Size(155, 20);
            lblGiaKhungGio.TabIndex = 6;
            lblGiaKhungGio.Text = "(Giá: 100.000 đ / vị trí)";
            // 
            // lblTamTinhTien
            // 
            lblTamTinhTien.BorderStyle = BorderStyle.Fixed3D;
            lblTamTinhTien.Location = new Point(20, 195);
            lblTamTinhTien.Name = "lblTamTinhTien";
            lblTamTinhTien.Size = new Size(265, 30);
            lblTamTinhTien.TabIndex = 2;
            lblTamTinhTien.Text = "0 VNĐ";
            lblTamTinhTien.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTamTinhTienLabel
            // 
            lblTamTinhTienLabel.AutoSize = true;
            lblTamTinhTienLabel.Location = new Point(20, 170);
            lblTamTinhTienLabel.Name = "lblTamTinhTienLabel";
            lblTamTinhTienLabel.Size = new Size(100, 20);
            lblTamTinhTienLabel.TabIndex = 8;
            lblTamTinhTienLabel.Text = "Tạm tính tiền:";
            // 
            // lblSoViTriChon
            // 
            lblSoViTriChon.AutoSize = true;
            lblSoViTriChon.Location = new Point(165, 130);
            lblSoViTriChon.Name = "lblSoViTriChon";
            lblSoViTriChon.Size = new Size(17, 20);
            lblSoViTriChon.TabIndex = 1;
            lblSoViTriChon.Text = "0";
            // 
            // lblSoViTriChonLabel
            // 
            lblSoViTriChonLabel.AutoSize = true;
            lblSoViTriChonLabel.Location = new Point(20, 130);
            lblSoViTriChonLabel.Name = "lblSoViTriChonLabel";
            lblSoViTriChonLabel.Size = new Size(137, 20);
            lblSoViTriChonLabel.TabIndex = 7;
            lblSoViTriChonLabel.Text = "Số vị trí đang chọn:";
            // 
            // cboKhungGio
            // 
            cboKhungGio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhungGio.FormattingEnabled = true;
            cboKhungGio.Location = new Point(20, 60);
            cboKhungGio.Name = "cboKhungGio";
            cboKhungGio.Size = new Size(265, 28);
            cboKhungGio.TabIndex = 0;
            cboKhungGio.SelectedIndexChanged += cboKhungGio_SelectedIndexChanged;
            // 
            // lblKhungGio
            // 
            lblKhungGio.AutoSize = true;
            lblKhungGio.Location = new Point(20, 35);
            lblKhungGio.Name = "lblKhungGio";
            lblKhungGio.Size = new Size(117, 20);
            lblKhungGio.TabIndex = 5;
            lblKhungGio.Text = "Chọn khung giờ:";
            // 
            // pnlLegends
            // 
            pnlLegends.Controls.Add(lblLegendBooked);
            pnlLegends.Controls.Add(lblLegendBookedBox);
            pnlLegends.Controls.Add(lblLegendSelected);
            pnlLegends.Controls.Add(lblLegendSelectedBox);
            pnlLegends.Controls.Add(lblLegendEmpty);
            pnlLegends.Controls.Add(lblLegendEmptyBox);
            pnlLegends.Location = new Point(15, 385);
            pnlLegends.Name = "pnlLegends";
            pnlLegends.Size = new Size(460, 35);
            pnlLegends.TabIndex = 3;
            // 
            // lblLegendBooked
            // 
            lblLegendBooked.AutoSize = true;
            lblLegendBooked.Location = new Point(345, 8);
            lblLegendBooked.Name = "lblLegendBooked";
            lblLegendBooked.Size = new Size(54, 20);
            lblLegendBooked.TabIndex = 5;
            lblLegendBooked.Text = "Đã đặt";
            // 
            // lblLegendBookedBox
            // 
            lblLegendBookedBox.BackColor = Color.Crimson;
            lblLegendBookedBox.BorderStyle = BorderStyle.FixedSingle;
            lblLegendBookedBox.Location = new Point(315, 7);
            lblLegendBookedBox.Name = "lblLegendBookedBox";
            lblLegendBookedBox.Size = new Size(22, 22);
            lblLegendBookedBox.TabIndex = 4;
            // 
            // lblLegendSelected
            // 
            lblLegendSelected.AutoSize = true;
            lblLegendSelected.Location = new Point(190, 8);
            lblLegendSelected.Name = "lblLegendSelected";
            lblLegendSelected.Size = new Size(82, 20);
            lblLegendSelected.TabIndex = 3;
            lblLegendSelected.Text = "Đang chọn";
            // 
            // lblLegendSelectedBox
            // 
            lblLegendSelectedBox.BackColor = Color.ForestGreen;
            lblLegendSelectedBox.BorderStyle = BorderStyle.FixedSingle;
            lblLegendSelectedBox.Location = new Point(160, 7);
            lblLegendSelectedBox.Name = "lblLegendSelectedBox";
            lblLegendSelectedBox.Size = new Size(22, 22);
            lblLegendSelectedBox.TabIndex = 2;
            // 
            // lblLegendEmpty
            // 
            lblLegendEmpty.AutoSize = true;
            lblLegendEmpty.Location = new Point(40, 8);
            lblLegendEmpty.Name = "lblLegendEmpty";
            lblLegendEmpty.Size = new Size(74, 20);
            lblLegendEmpty.TabIndex = 1;
            lblLegendEmpty.Text = "Chỗ trống";
            // 
            // lblLegendEmptyBox
            // 
            lblLegendEmptyBox.BackColor = SystemColors.Control;
            lblLegendEmptyBox.BorderStyle = BorderStyle.FixedSingle;
            lblLegendEmptyBox.Location = new Point(10, 7);
            lblLegendEmptyBox.Name = "lblLegendEmptyBox";
            lblLegendEmptyBox.Size = new Size(22, 22);
            lblLegendEmptyBox.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 430);
            Controls.Add(pnlLegends);
            Controls.Add(grpInfo);
            Controls.Add(pnlSlotMatrix);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 4 - Sơ đồ chọn vị trí chỗ ngồi / Đặt bàn hẹn giờ";
            Load += Form1_Load;
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            pnlLegends.ResumeLayout(false);
            pnlLegends.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnlSlotMatrix;
        private GroupBox grpInfo;
        private Label lblKhungGio;
        private ComboBox cboKhungGio;
        private Label lblSoViTriChonLabel;
        private Label lblSoViTriChon;
        private Label lblTamTinhTienLabel;
        private Label lblTamTinhTien;
        private Button btnXacNhanDat;
        private Button btnHuyChonTatCa;
        private Label lblGiaKhungGio;
        private Panel pnlLegends;
        private Label lblLegendEmptyBox;
        private Label lblLegendEmpty;
        private Label lblLegendSelectedBox;
        private Label lblLegendSelected;
        private Label lblLegendBookedBox;
        private Label lblLegendBooked;
    }
}
