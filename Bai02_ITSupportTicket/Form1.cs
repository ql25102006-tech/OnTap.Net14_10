using System.Text;

namespace Bai02_ITSupportTicket
{
    public partial class Form1 : Form
    {
        private string duongDanAnh = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nạp danh mục loại sự cố
            cboLoaiSuCo.Items.AddRange(new object[] {
                "Phần cứng",
                "Phần mềm",
                "Mạng",
                "Tài khoản"
            });
            cboLoaiSuCo.SelectedIndex = 0;
            dtpNgayGhiNhan.Value = DateTime.Now;
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                ofd.Title = "Chọn ảnh chụp sự cố lỗi";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    duongDanAnh = ofd.FileName;
                    picAnhLoi.Image = Image.FromFile(duongDanAnh);
                }
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            // Validate thông tin
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người yêu cầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiYeuCau.Focus();
                return;
            }

            // Mức độ ưu tiên
            string mucDoUuTien = "Thấp";
            if (rdoTrungBinh.Checked) mucDoUuTien = "Trung bình";
            else if (rdoKhanCap.Checked) mucDoUuTien = "Khẩn cấp";

            // Thiết bị ảnh hưởng
            List<string> dsThietBi = new List<string>();
            if (chkMayTinhBan.Checked) dsThietBi.Add("Máy tính bàn");
            if (chkLaptop.Checked) dsThietBi.Add("Laptop");
            if (chkMayIn.Checked) dsThietBi.Add("Máy in");
            if (chkDienThoai.Checked) dsThietBi.Add("Điện thoại");

            string strThietBi = dsThietBi.Count > 0 ? string.Join(", ", dsThietBi) : "(Không chọn)";

            // Hiển thị tóm tắt thông tin qua MessageBox
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== TIẾP NHẬN SỰ CỐ IT THÀNH CÔNG ===");
            sb.AppendLine();
            sb.AppendLine($"• Mã phiếu: {txtMaPhieu.Text.Trim()}");
            sb.AppendLine($"• Người yêu cầu: {txtNguoiYeuCau.Text.Trim()}");
            sb.AppendLine($"• Ngày ghi nhận: {dtpNgayGhiNhan.Value:dd/MM/yyyy}");
            sb.AppendLine($"• Mức độ ưu tiên: {mucDoUuTien}");
            sb.AppendLine($"• Loại sự cố: {cboLoaiSuCo.SelectedItem}");
            sb.AppendLine($"• Thiết bị ảnh hưởng: {strThietBi}");
            sb.AppendLine($"• Ảnh đính kèm: {(string.IsNullOrEmpty(duongDanAnh) ? "Chưa có" : Path.GetFileName(duongDanAnh))}");

            MessageBox.Show(sb.ToString(), "Thông tin phiếu tiếp nhận IT", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;
            rdoTrungBinh.Checked = true;
            cboLoaiSuCo.SelectedIndex = 0;
            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            if (picAnhLoi.Image != null)
            {
                picAnhLoi.Image.Dispose();
                picAnhLoi.Image = null;
            }
            duongDanAnh = "";

            txtMaPhieu.Focus();
        }
    }
}
