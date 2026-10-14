namespace Bai03_ItemListManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nạp ComboBox Đơn vị tính
            cboDonViTinh.Items.AddRange(new object[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDonViTinh.SelectedIndex = 0;

            // Thêm vài dữ liệu mẫu
            ThemDongListView("VT01", "Dây cáp mạng Cat6", "Mét", 8000);
            ThemDongListView("VT02", "Đầu bấm mạng RJ45", "Cái", 3000);
            ThemDongListView("VT03", "Keo tản nhiệt", "Bộ", 45000);
        }

        private void ThemDongListView(string ma, string ten, string dvt, decimal donGia)
        {
            ListViewItem item = new ListViewItem(ma);
            item.SubItems.Add(ten);
            item.SubItems.Add(dvt);
            item.SubItems.Add(donGia.ToString("N0"));
            lvwVatTu.Items.Add(item);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string ma = txtMaVatTu.Text.Trim();
            string ten = txtTenVatTu.Text.Trim();

            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Vui lòng nhập mã vật tư!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVatTu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Vui lòng nhập tên vật tư!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenVatTu.Focus();
                return;
            }

            // Kiểm tra trùng mã vật tư trong ListView
            foreach (ListViewItem item in lvwVatTu.Items)
            {
                if (item.Text.Equals(ma, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Mã vật tư '{ma}' đã tồn tại trong danh sách!", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMaVatTu.SelectAll();
                    txtMaVatTu.Focus();
                    return;
                }
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá nhập phải là số không âm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.SelectAll();
                txtDonGia.Focus();
                return;
            }

            string dvt = cboDonViTinh.SelectedItem?.ToString() ?? "Cái";
            ThemDongListView(ma, ten, dvt, donGia);

            LamMoiForm();
            MessageBox.Show("Thêm vật tư mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvwVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng trong danh sách để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string ma = txtMaVatTu.Text.Trim();
            string ten = txtTenVatTu.Text.Trim();

            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Không được để trống Mã VT hoặc Tên VT!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá nhập phải là số không âm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = lvwVatTu.SelectedItems[0];

            // Nếu người dùng đổi mã VT, kiểm tra trùng với các dòng khác
            if (!selectedItem.Text.Equals(ma, StringComparison.OrdinalIgnoreCase))
            {
                foreach (ListViewItem item in lvwVatTu.Items)
                {
                    if (item != selectedItem && item.Text.Equals(ma, StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show($"Mã vật tư '{ma}' đã trùng với dòng khác!", "Lỗi trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            selectedItem.Text = ma;
            selectedItem.SubItems[1].Text = ten;
            selectedItem.SubItems[2].Text = cboDonViTinh.SelectedItem?.ToString() ?? "Cái";
            selectedItem.SubItems[3].Text = donGia.ToString("N0");

            MessageBox.Show("Cập nhật thông tin vật tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lvwVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string ma = lvwVatTu.SelectedItems[0].Text;
            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa vật tư [{ma}] khỏi danh sách?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                lvwVatTu.Items.Remove(lvwVatTu.SelectedItems[0]);
                LamMoiForm();
            }
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (lvwVatTu.Items.Count == 0) return;

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa TOÀN BỘ danh sách vật tư?", "Xác nhận xóa toàn bộ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                lvwVatTu.Items.Clear();
                LamMoiForm();
            }
        }

        private void lvwVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwVatTu.SelectedItems.Count > 0)
            {
                ListViewItem item = lvwVatTu.SelectedItems[0];
                txtMaVatTu.Text = item.Text;
                txtTenVatTu.Text = item.SubItems[1].Text;

                string dvt = item.SubItems[2].Text;
                cboDonViTinh.SelectedItem = dvt;

                string giaStr = item.SubItems[3].Text.Replace(",", "").Replace(".", "");
                txtDonGia.Text = giaStr;
            }
        }

        private void LamMoiForm()
        {
            txtMaVatTu.Clear();
            txtTenVatTu.Clear();
            txtDonGia.Clear();
            cboDonViTinh.SelectedIndex = 0;
            txtMaVatTu.Focus();
        }
    }
}
