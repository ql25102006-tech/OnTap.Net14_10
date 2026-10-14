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

            // Thêm dữ liệu mẫu ban đầu
            ThemDongMoi("Sách Lập trình C#", 2, 0.85, 125000);
            ThemDongMoi("Bàn phím máy tính", 1, 0.70, 650000);

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
            ThemDongMoi();
            if (dgvItems.RowCount > 0)
            {
                int newRowIndex = dgvItems.RowCount - 1;
                // Nếu dòng cuối là new row (dòng trống chờ nhập) thì chọn dòng vừa thêm
                if (dgvItems.Rows[newRowIndex].IsNewRow && newRowIndex > 0)
                {
                    newRowIndex--;
                }
                dgvItems.CurrentCell = dgvItems.Rows[newRowIndex].Cells[0];
                dgvItems.Focus();
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
                string tenHang = dgvItems.CurrentRow.Cells[0].Value?.ToString() ?? "mặt hàng này";
                DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa dòng [{tenHang}] khỏi đơn hàng?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    dgvItems.Rows.Remove(dgvItems.CurrentRow);
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
            // Nếu người dùng nhấn phím Delete khi đang chọn cả dòng hoặc không trong chế độ gõ chữ cell
            if (e.KeyCode == Keys.Delete && !dgvItems.IsCurrentCellInEditMode)
            {
                XoaDongDangChon();
                e.Handled = true;
            }
        }

        // Kiểm tra lỗi (Validate) bằng ErrorProvider khi người dùng đang nhập dữ liệu
        private void dgvItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvItems.RowCount) return;
            if (dgvItems.Rows[e.RowIndex].IsNewRow) return;

            string inputVal = e.FormattedValue?.ToString()?.Trim() ?? string.Empty;

            // Kiểm tra cột 1: Số lượng (nguyên > 0)
            if (e.ColumnIndex == 1)
            {
                if (string.IsNullOrEmpty(inputVal) || !int.TryParse(inputVal, out int sl) || sl <= 0)
                {
                    dgvItems.Rows[e.RowIndex].Cells[1].ErrorText = "Số lượng phải là số nguyên > 0!";
                    errorProvider1.SetError(dgvItems, "Số lượng tại dòng " + (e.RowIndex + 1) + " phải là số nguyên > 0!");
                }
                else
                {
                    dgvItems.Rows[e.RowIndex].Cells[1].ErrorText = string.Empty;
                    errorProvider1.SetError(dgvItems, string.Empty);
                }
            }
            // Kiểm tra cột 2: Trọng lượng (số > 0)
            else if (e.ColumnIndex == 2)
            {
                if (string.IsNullOrEmpty(inputVal) || !double.TryParse(inputVal, out double tl) || tl <= 0)
                {
                    dgvItems.Rows[e.RowIndex].Cells[2].ErrorText = "Trọng lượng phải > 0 kg!";
                    errorProvider1.SetError(dgvItems, "Trọng lượng tại dòng " + (e.RowIndex + 1) + " phải > 0 kg!");
                }
                else
                {
                    dgvItems.Rows[e.RowIndex].Cells[2].ErrorText = string.Empty;
                    errorProvider1.SetError(dgvItems, string.Empty);
                }
            }
        }

        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvItems.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        // Tự động tính toán realtime khi thay đổi giá trị
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
            if (row.IsNewRow) return;

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
            TinhToanLaiToanBo();
        }

        private void TinhToanLaiToanBo()
        {
            int tongSoLuong = 0;
            double tongTrongLuong = 0;
            decimal tongTien = 0;

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.IsNewRow) continue;

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
