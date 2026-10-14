namespace Bai03_ItemListManager
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
            grpInput = new GroupBox();
            btnXoaToanBo = new Button();
            btnXoaDong = new Button();
            btnCapNhat = new Button();
            btnThemMoi = new Button();
            txtDonGia = new TextBox();
            lblDonGia = new Label();
            cboDonViTinh = new ComboBox();
            lblDonViTinh = new Label();
            txtTenVatTu = new TextBox();
            lblTenVatTu = new Label();
            txtMaVatTu = new TextBox();
            lblMaVatTu = new Label();
            grpList = new GroupBox();
            lvwVatTu = new ListView();
            colMaVT = new ColumnHeader();
            colTenVT = new ColumnHeader();
            colDonViTinh = new ColumnHeader();
            colDonGia = new ColumnHeader();
            grpInput.SuspendLayout();
            grpList.SuspendLayout();
            SuspendLayout();
            // 
            // grpInput
            // 
            grpInput.Controls.Add(btnXoaToanBo);
            grpInput.Controls.Add(btnXoaDong);
            grpInput.Controls.Add(btnCapNhat);
            grpInput.Controls.Add(btnThemMoi);
            grpInput.Controls.Add(txtDonGia);
            grpInput.Controls.Add(lblDonGia);
            grpInput.Controls.Add(cboDonViTinh);
            grpInput.Controls.Add(lblDonViTinh);
            grpInput.Controls.Add(txtTenVatTu);
            grpInput.Controls.Add(lblTenVatTu);
            grpInput.Controls.Add(txtMaVatTu);
            grpInput.Controls.Add(lblMaVatTu);
            grpInput.Location = new Point(15, 15);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(320, 390);
            grpInput.TabIndex = 0;
            grpInput.TabStop = false;
            grpInput.Text = "Khung nhập liệu";
            // 
            // btnXoaToanBo
            // 
            btnXoaToanBo.Location = new Point(165, 330);
            btnXoaToanBo.Name = "btnXoaToanBo";
            btnXoaToanBo.Size = new Size(135, 34);
            btnXoaToanBo.TabIndex = 7;
            btnXoaToanBo.Text = "Xóa toàn bộ";
            btnXoaToanBo.UseVisualStyleBackColor = true;
            btnXoaToanBo.Click += btnXoaToanBo_Click;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Location = new Point(15, 330);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(135, 34);
            btnXoaDong.TabIndex = 6;
            btnXoaDong.Text = "Xóa dòng";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(165, 280);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(135, 34);
            btnCapNhat.TabIndex = 5;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(15, 280);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(135, 34);
            btnThemMoi.TabIndex = 4;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(115, 215);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(185, 27);
            txtDonGia.TabIndex = 3;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(15, 218);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(99, 20);
            lblDonGia.TabIndex = 11;
            lblDonGia.Text = "Đơn giá nhập:";
            // 
            // cboDonViTinh
            // 
            cboDonViTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDonViTinh.FormattingEnabled = true;
            cboDonViTinh.Location = new Point(115, 155);
            cboDonViTinh.Name = "cboDonViTinh";
            cboDonViTinh.Size = new Size(185, 28);
            cboDonViTinh.TabIndex = 2;
            // 
            // lblDonViTinh
            // 
            lblDonViTinh.AutoSize = true;
            lblDonViTinh.Location = new Point(15, 158);
            lblDonViTinh.Name = "lblDonViTinh";
            lblDonViTinh.Size = new Size(84, 20);
            lblDonViTinh.TabIndex = 10;
            lblDonViTinh.Text = "Đơn vị tính:";
            // 
            // txtTenVatTu
            // 
            txtTenVatTu.Location = new Point(115, 95);
            txtTenVatTu.Name = "txtTenVatTu";
            txtTenVatTu.Size = new Size(185, 27);
            txtTenVatTu.TabIndex = 1;
            // 
            // lblTenVatTu
            // 
            lblTenVatTu.AutoSize = true;
            lblTenVatTu.Location = new Point(15, 98);
            lblTenVatTu.Name = "lblTenVatTu";
            lblTenVatTu.Size = new Size(76, 20);
            lblTenVatTu.TabIndex = 9;
            lblTenVatTu.Text = "Tên vật tư:";
            // 
            // txtMaVatTu
            // 
            txtMaVatTu.Location = new Point(115, 40);
            txtMaVatTu.Name = "txtMaVatTu";
            txtMaVatTu.Size = new Size(185, 27);
            txtMaVatTu.TabIndex = 0;
            // 
            // lblMaVatTu
            // 
            lblMaVatTu.AutoSize = true;
            lblMaVatTu.Location = new Point(15, 43);
            lblMaVatTu.Name = "lblMaVatTu";
            lblMaVatTu.Size = new Size(74, 20);
            lblMaVatTu.TabIndex = 8;
            lblMaVatTu.Text = "Mã vật tư:";
            // 
            // grpList
            // 
            grpList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpList.Controls.Add(lvwVatTu);
            grpList.Location = new Point(350, 15);
            grpList.Name = "grpList";
            grpList.Size = new Size(480, 390);
            grpList.TabIndex = 1;
            grpList.TabStop = false;
            grpList.Text = "Khung danh sách";
            // 
            // lvwVatTu
            // 
            lvwVatTu.Columns.AddRange(new ColumnHeader[] { colMaVT, colTenVT, colDonViTinh, colDonGia });
            lvwVatTu.Dock = DockStyle.Fill;
            lvwVatTu.FullRowSelect = true;
            lvwVatTu.GridLines = true;
            lvwVatTu.Location = new Point(3, 23);
            lvwVatTu.MultiSelect = false;
            lvwVatTu.Name = "lvwVatTu";
            lvwVatTu.Size = new Size(474, 364);
            lvwVatTu.TabIndex = 0;
            lvwVatTu.UseCompatibleStateImageBehavior = false;
            lvwVatTu.View = View.Details;
            lvwVatTu.SelectedIndexChanged += lvwVatTu_SelectedIndexChanged;
            // 
            // colMaVT
            // 
            colMaVT.Text = "Mã VT";
            colMaVT.Width = 90;
            // 
            // colTenVT
            // 
            colTenVT.Text = "Tên VT";
            colTenVT.Width = 150;
            // 
            // colDonViTinh
            // 
            colDonViTinh.Text = "Đơn vị tính";
            colDonViTinh.Width = 95;
            // 
            // colDonGia
            // 
            colDonGia.Text = "Đơn giá";
            colDonGia.TextAlign = HorizontalAlignment.Right;
            colDonGia.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 420);
            Controls.Add(grpList);
            Controls.Add(grpInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bài 3 - Quản lý danh mục Vật tư / Linh kiện";
            Load += Form1_Load;
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            grpList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpInput;
        private Label lblMaVatTu;
        private TextBox txtMaVatTu;
        private Label lblTenVatTu;
        private TextBox txtTenVatTu;
        private Label lblDonViTinh;
        private ComboBox cboDonViTinh;
        private Label lblDonGia;
        private TextBox txtDonGia;
        private Button btnThemMoi;
        private Button btnCapNhat;
        private Button btnXoaDong;
        private Button btnXoaToanBo;
        private GroupBox grpList;
        private ListView lvwVatTu;
        private ColumnHeader colMaVT;
        private ColumnHeader colTenVT;
        private ColumnHeader colDonViTinh;
        private ColumnHeader colDonGia;
    }
}
