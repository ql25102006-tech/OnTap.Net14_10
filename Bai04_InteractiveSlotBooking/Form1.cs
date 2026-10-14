namespace Bai04_InteractiveSlotBooking
{
    public partial class Form1 : Form
    {
        // 0: Trống (màu mặc định), 1: Đang chọn (Xanh lá), 2: Đã đặt (Đỏ)
        private const int STATE_EMPTY = 0;
        private const int STATE_SELECTED = 1;
        private const int STATE_BOOKED = 2;

        private readonly Color COLOR_EMPTY = SystemColors.Control;
        private readonly Color COLOR_SELECTED = Color.ForestGreen;
        private readonly Color COLOR_BOOKED = Color.Crimson;

        private List<Button> danhSachNut = new List<Button>();
        private decimal donGiaHienTai = 100000m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKhungGio.Items.Add("Khung giờ Sáng (100.000đ)");
            cboKhungGio.Items.Add("Khung giờ Tối (150.000đ)");
            cboKhungGio.SelectedIndex = 0;

            KhoiTaoMaTranViTri(4, 5);
        }

        private void KhoiTaoMaTranViTri(int soHang, int soCot)
        {
            pnlSlotMatrix.SuspendLayout();
            pnlSlotMatrix.Controls.Clear();
            danhSachNut.Clear();

            int stt = 1;
            for (int r = 0; r < soHang; r++)
            {
                for (int c = 0; c < soCot; c++)
                {
                    Button btn = new Button();
                    btn.Text = $"Bàn {stt:D2}";
                    btn.Name = $"btnSlot_{stt}";
                    btn.Dock = DockStyle.Fill;
                    btn.Margin = new Padding(3);
                    btn.BackColor = COLOR_EMPTY;
                    btn.ForeColor = SystemColors.ControlText;
                    btn.Tag = STATE_EMPTY;
                    btn.UseVisualStyleBackColor = true;

                    // Gán chung 1 Event Handler
                    btn.Click += SlotButton_Click;

                    // Giả lập 2 bàn đã có người đặt trước
                    if (stt == 4 || stt == 11)
                    {
                        btn.Tag = STATE_BOOKED;
                        btn.BackColor = COLOR_BOOKED;
                        btn.ForeColor = Color.White;
                        btn.UseVisualStyleBackColor = false;
                        btn.Cursor = Cursors.No;
                    }

                    pnlSlotMatrix.Controls.Add(btn, c, r);
                    danhSachNut.Add(btn);
                    stt++;
                }
            }

            pnlSlotMatrix.ResumeLayout();
            CapNhatThongKeRealtime();
        }

        private void SlotButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int trangThai)
            {
                if (trangThai == STATE_BOOKED)
                {
                    MessageBox.Show($"Vị trí [{btn.Text}] đã có khách đặt trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (trangThai == STATE_EMPTY)
                {
                    btn.Tag = STATE_SELECTED;
                    btn.BackColor = COLOR_SELECTED;
                    btn.ForeColor = Color.White;
                    btn.UseVisualStyleBackColor = false;
                }
                else if (trangThai == STATE_SELECTED)
                {
                    btn.Tag = STATE_EMPTY;
                    btn.BackColor = COLOR_EMPTY;
                    btn.ForeColor = SystemColors.ControlText;
                    btn.UseVisualStyleBackColor = true;
                }

                CapNhatThongKeRealtime();
            }
        }

        private void CapNhatThongKeRealtime()
        {
            int soViTriDangChon = 0;
            foreach (Button btn in danhSachNut)
            {
                if (btn.Tag is int tag && tag == STATE_SELECTED)
                {
                    soViTriDangChon++;
                }
            }

            decimal tamTinhTien = soViTriDangChon * donGiaHienTai;

            lblSoViTriChon.Text = soViTriDangChon.ToString();
            lblTamTinhTien.Text = string.Format("{0:N0} VNĐ", tamTinhTien);
        }

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhungGio.SelectedIndex == 0)
            {
                donGiaHienTai = 100000m;
                lblGiaKhungGio.Text = "(Giá: 100.000 đ / vị trí)";
            }
            else
            {
                donGiaHienTai = 150000m;
                lblGiaKhungGio.Text = "(Giá: 150.000 đ / vị trí)";
            }

            CapNhatThongKeRealtime();
        }

        private void btnXacNhanDat_Click(object sender, EventArgs e)
        {
            List<Button> dsDangChon = danhSachNut.Where(b => b.Tag is int tag && tag == STATE_SELECTED).ToList();

            if (dsDangChon.Count == 0)
            {
                MessageBox.Show("Vui lòng click chọn ít nhất 1 vị trí để đặt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string danhSachTen = string.Join(", ", dsDangChon.Select(b => b.Text));
            decimal tongTien = dsDangChon.Count * donGiaHienTai;

            DialogResult dr = MessageBox.Show(
                $"Xác nhận đặt {dsDangChon.Count} vị trí: [{danhSachTen}]\nKhung giờ: {cboKhungGio.SelectedItem}\nTổng tiền: {tongTien:N0} VNĐ?",
                "Xác nhận đặt bàn",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                foreach (Button btn in dsDangChon)
                {
                    btn.Tag = STATE_BOOKED;
                    btn.BackColor = COLOR_BOOKED;
                    btn.ForeColor = Color.White;
                    btn.UseVisualStyleBackColor = false;
                    btn.Cursor = Cursors.No;
                }

                CapNhatThongKeRealtime();
                MessageBox.Show("Đặt chỗ thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuyChonTatCa_Click(object sender, EventArgs e)
        {
            foreach (Button btn in danhSachNut)
            {
                if (btn.Tag is int tag && tag == STATE_SELECTED)
                {
                    btn.Tag = STATE_EMPTY;
                    btn.BackColor = COLOR_EMPTY;
                    btn.ForeColor = SystemColors.ControlText;
                    btn.UseVisualStyleBackColor = true;
                }
            }

            CapNhatThongKeRealtime();
        }
    }
}
