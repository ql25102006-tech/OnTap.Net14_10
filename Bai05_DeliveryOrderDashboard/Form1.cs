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
                dgvItems.CurrentCell = dgvItems.Rows[dgvItems.RowCount - 1].Cells[0];
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
                dgvItems.Rows.Remove(dgvItems.CurrentRow);
                TinhToanLaiToanBo();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnThemDong.PerformClick();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Delete && !(ActiveControl is TextBox))
            {
                XoaDongDangChon();
                e.Handled = true;
            }
        }

        private void dgvItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvItems.RowCount) return;

            DataGridViewRow row = dgvItems.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            bool soLuongHopLe = true;
            int soLuong = 0;
            object? valSoLuong = row.Cells[1].Value;
            if (valSoLuong == null || !int.TryParse(valSoLuong.ToString()?.Trim(), out soLuong) || soLuong <= 0)
            {
                row.Cells[1].ErrorText = "Số lượng phải là số nguyên > 0";
                soLuongHopLe = false;
            }
            else
            {
                row.Cells[1].ErrorText = string.Empty;
            }

            object? valTrongLuong = row.Cells[2].Value;
            if (valTrongLuong == null || !double.TryParse(valTrongLuong.ToString()?.Trim(), out double trongLuong) || trongLuong <= 0)
            {
                row.Cells[2].ErrorText = "Trọng lượng phải > 0 kg";
            }
            else
            {
                row.Cells[2].ErrorText = string.Empty;
            }

            decimal donGia = 0;
            object? valDonGia = row.Cells[3].Value;
            if (valDonGia != null)
            {
                decimal.TryParse(valDonGia.ToString()?.Trim(), out donGia);
            }

            if (soLuongHopLe && soLuong > 0 && donGia >= 0)
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
