namespace Bai05_DeliveryOrderDashboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMaDonHang.Text = $"DH-{DateTime.Now:yyyyMMddHHmm}";
            CapNhatThoiGianRealtime();

            // Mở lên ban đầu thêm 1 dòng đầu tiên để người dùng bắt đầu nhập
            ThemDongMoi();
            TinhToanLaiToanBo();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            CapNhatThoiGianRealtime();
        }

        private void CapNhatThoiGianRealtime()
        {
            sslThoiGian.Text = $"Thời gian: {DateTime.Now:HH:mm:ss dd/MM/yyyy}";
        }

        private void ThemDongMoi(string tenHang = "", int soLuong = 1, double trongLuong = 0.5, decimal donGia = 0)
        {
            int index = dgvItems.Rows.Add();
            DataGridViewRow row = dgvItems.Rows[index];
            row.Cells[0].Value = tenHang;
            row.Cells[1].Value = soLuong;
            row.Cells[2].Value = trongLuong;
            row.Cells[3].Value = donGia;
            row.Cells[4].Value = (soLuong * donGia).ToString("N0");
        }

        private void btnThemDong_Click(object sender, EventArgs e)
        {
            // Kiểm tra: Nếu trong bảng đã có dòng nào chưa nhập xong hoặc dữ liệu lỗi thì không cho thêm tiếp dòng mới
            if (dgvItems.RowCount > 0)
            {
                DataGridViewRow lastRow = dgvItems.Rows[dgvItems.RowCount - 1];
                string ten = lastRow.Cells[0].Value?.ToString()?.Trim() ?? string.Empty;

                if (string.IsNullOrEmpty(ten))
                {
                    MessageBox.Show("Vui lòng nhập Tên hàng cho dòng hiện tại trước khi thêm dòng mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvItems.CurrentCell = lastRow.Cells[0];
                    dgvItems.BeginEdit(true);
                    return;
                }

                // Kiểm tra Số lượng > 0
                string? strSL = lastRow.Cells[1].Value?.ToString()?.Trim();
                if (string.IsNullOrEmpty(strSL) || !int.TryParse(strSL, out int sl) || sl <= 0)
                {
                    MessageBox.Show("Số lượng phải là số nguyên lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvItems.CurrentCell = lastRow.Cells[1];
                    dgvItems.BeginEdit(true);
                    return;
                }

                // Kiểm tra Trọng lượng > 0
                string? strTL = lastRow.Cells[2].Value?.ToString()?.Trim();
                if (string.IsNullOrEmpty(strTL) || !double.TryParse(strTL, out double tl) || tl <= 0)
                {
                    MessageBox.Show("Trọng lượng phải lớn hơn 0 kg!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvItems.CurrentCell = lastRow.Cells[2];
                    dgvItems.BeginEdit(true);
                    return;
                }
            }

            ThemDongMoi();
            if (dgvItems.RowCount > 0)
            {
                int newIndex = dgvItems.RowCount - 1;
                dgvItems.CurrentCell = dgvItems.Rows[newIndex].Cells[0];
                dgvItems.BeginEdit(true);
            }
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            XoaDongDangChon();
        }

        private void XoaDongDangChon()
        {
            if (dgvItems.CurrentRow != null && !dgvItems.CurrentRow.IsNewRow)
            {
                string tenHang = dgvItems.CurrentRow.Cells[0].Value?.ToString()?.Trim() ?? string.Empty;
                string displayTen = string.IsNullOrEmpty(tenHang) ? "dòng đang chọn" : $"[{tenHang}]";

                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa {displayTen} khỏi đơn hàng?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dgvItems.Rows.Remove(dgvItems.CurrentRow);
                    errorProvider1.SetError(dgvItems, string.Empty);
                    TinhToanLaiToanBo();
                }
            }
        }

        // Hỗ trợ phím tắt F2 và Delete
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThemDong.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete && !(ActiveControl is TextBox) && !(ActiveControl is DataGridView))
            {
                XoaDongDangChon();
                e.Handled = true;
            }
        }

        private void dgvItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && !dgvItems.IsCurrentCellInEditMode)
            {
                XoaDongDangChon();
                e.Handled = true;
            }
        }

        // Bắt lỗi cảnh báo đỏ ErrorProvider khi người dùng nhập Số lượng hoặc Trọng lượng <= 0
        private void dgvItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvItems.RowCount) return;

            string inputVal = e.FormattedValue?.ToString()?.Trim() ?? string.Empty;

            // Kiểm tra cột 1: Số lượng
            if (e.ColumnIndex == 1)
            {
                if (string.IsNullOrEmpty(inputVal) || !int.TryParse(inputVal, out int sl) || sl <= 0)
                {
                    string msg = "Số lượng tại dòng " + (e.RowIndex + 1) + " phải là số nguyên > 0!";
                    dgvItems.Rows[e.RowIndex].Cells[1].ErrorText = msg;
                    errorProvider1.SetError(dgvItems, msg);
                }
                else
                {
                    dgvItems.Rows[e.RowIndex].Cells[1].ErrorText = string.Empty;
                    KiemTraXoaErrorProviderTong();
                }
            }
            // Kiểm tra cột 2: Trọng lượng
            else if (e.ColumnIndex == 2)
            {
                if (string.IsNullOrEmpty(inputVal) || !double.TryParse(inputVal, out double tl) || tl <= 0)
                {
                    string msg = "Trọng lượng tại dòng " + (e.RowIndex + 1) + " phải > 0 kg!";
                    dgvItems.Rows[e.RowIndex].Cells[2].ErrorText = msg;
                    errorProvider1.SetError(dgvItems, msg);
                }
                else
                {
                    dgvItems.Rows[e.RowIndex].Cells[2].ErrorText = string.Empty;
                    KiemTraXoaErrorProviderTong();
                }
            }
        }

        private void KiemTraXoaErrorProviderTong()
        {
            bool coLoi = false;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (!string.IsNullOrEmpty(row.Cells[1].ErrorText) || !string.IsNullOrEmpty(row.Cells[2].ErrorText))
                {
                    coLoi = true;
                    break;
                }
            }
            if (!coLoi)
            {
                errorProvider1.SetError(dgvItems, string.Empty);
            }
        }

        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            KiemTraXoaErrorProviderTong();
        }

        // Tự động tính toán realtime ngay khi người dùng gõ phím thay đổi giá trị
        private void dgvItems_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvItems.IsCurrentCellDirty)
            {
                dgvItems.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvItems.RowCount) return;

            DataGridViewRow row = dgvItems.Rows[e.RowIndex];

            int soLuong = 0;
            var valSL = row.Cells[1].Value;
            bool slOk = valSL != null && int.TryParse(valSL.ToString()?.Trim(), out soLuong) && soLuong > 0;

            decimal donGia = 0;
            var valDG = row.Cells[3].Value;
            bool dgOk = valDG != null && decimal.TryParse(valDG.ToString()?.Trim(), out donGia) && donGia >= 0;

            if (slOk && dgOk)
            {
                row.Cells[4].Value = (soLuong * donGia).ToString("N0");
            }
            else
            {
                row.Cells[4].Value = "0";
            }

            TinhToanLaiToanBo();
        }

        private void dgvItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            KiemTraXoaErrorProviderTong();
            TinhToanLaiToanBo();
        }

        private void TinhToanLaiToanBo()
        {
            int tongSoLuong = 0;
            double tongTrongLuong = 0;
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                var cellSL = row.Cells[1].Value;
                if (cellSL != null && int.TryParse(cellSL.ToString()?.Trim(), out int sl) && sl > 0)
                {
                    tongSoLuong += sl;
                }

                var cellTL = row.Cells[2].Value;
                if (cellTL != null && double.TryParse(cellTL.ToString()?.Trim(), out double tl) && tl > 0)
                {
                    tongTrongLuong += tl;
                }

                var cellDG = row.Cells[3].Value;
                if (cellDG != null && decimal.TryParse(cellDG.ToString()?.Trim(), out decimal dg) && dg >= 0)
                {
                    if (cellSL != null && int.TryParse(cellSL.ToString()?.Trim(), out int slOk) && slOk > 0)
                    {
                        tongTien += slOk * dg;
                    }
                }
            }

            sslTongSoLuong.Text = $"Tổng SL: {tongSoLuong:N0}";
            sslTongTrongLuong.Text = $"Tổng TL: {tongTrongLuong:N2} kg";
            sslTongTien.Text = $"Tổng tiền: {tongTien:N0} VNĐ";
        }
    }
}
