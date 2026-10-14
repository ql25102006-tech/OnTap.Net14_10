namespace Bai01_ServiceChargeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu trống
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá dịch vụ!", "Cảnh báo lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoLuongKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng khách!", "Cảnh báo lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongKhach.Focus();
                return;
            }

            // Validate số hợp lệ
            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá dịch vụ phải là số không âm!", "Cảnh báo lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.SelectAll();
                txtDonGia.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuongKhach.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng khách phải là số nguyên lớn hơn 0!", "Cảnh báo lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuongKhach.SelectAll();
                txtSoLuongKhach.Focus();
                return;
            }

            decimal giamGia = 0;
            if (!string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                if (!decimal.TryParse(txtGiamGia.Text.Trim(), out giamGia) || giamGia < 0 || giamGia > 100)
                {
                    MessageBox.Show("Phần trăm giảm giá phải nằm trong khoảng từ 0 đến 100%!", "Cảnh báo lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGiamGia.SelectAll();
                    txtGiamGia.Focus();
                    return;
                }
            }

            // Công thức: Tổng tiền = (Đơn giá × Số lượng) × (100 - % Giảm) / 100
            decimal tongTien = (donGia * soLuong) * (100m - giamGia) / 100m;

            lblTongTien.Text = string.Format("{0:N0} VNĐ", tongTien);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuongKhach.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = "0 VNĐ";
            txtDonGia.Focus();
        }
    }
}
