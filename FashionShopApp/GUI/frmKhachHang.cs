using FashionShopApp.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace FashionShopApp.GUI
{
    public partial class frmKhachHang : Form
    {
        SQLConfig config = new SQLConfig(NguoiDungHienTai.CurentUser.nguoiDung.TenTaiKhoan, NguoiDungHienTai.CurentUser.nguoiDung.MatKhau);
        string sql;
        public frmKhachHang()
        {

            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            txt_IdKH.Enabled = false;
            btn_Luu.Enabled = false;
            btn_ResetTextBox.Enabled = false;
            loadDanhSachKH();
            txt_IdAcc.Focus();
        }
        void loadDanhSachKH()
        {
            sql = "SELECT *FROM KhachHang";
            DataTable dt = config.ExecuteSelectQuery(sql);

            dgv.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dgv.Columns[0].HeaderText = "Mã KH";
                dgv.Columns[1].HeaderText = "Mã Tài Khoản";
                dgv.Columns[2].HeaderText = "Tên Khách Hàng";
                dgv.Columns[3].HeaderText = "Ngày sinh";
                dgv.Columns[4].HeaderText = "Giới tính";
                dgv.Columns[5].HeaderText = "Địa chỉ";
                dgv.Columns[6].HeaderText = "Số ĐT";
                dgv.Columns[7].HeaderText = "Email";
            }
            dgv.AllowUserToAddRows = false;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                txt_IdKH.Text = dgv.Rows[index].Cells[0].Value.ToString();
                txt_IdAcc.Text = dgv.Rows[index].Cells[1].Value.ToString();
                txt_TenKH.Text = dgv.Rows[index].Cells[2].Value.ToString();
                txt_ngaysinh.Text = dgv.Rows[index].Cells[3].Value.ToString();
                txt_gioitinh.Text = dgv.Rows[index].Cells[4].Value.ToString();
                txt_diachi.Text = dgv.Rows[index].Cells[5].Value.ToString();
                txt_sdt.Text = dgv.Rows[index].Cells[6].Value.ToString();
                txt_mail.Text = dgv.Rows[index].Cells[7].Value.ToString();
            }
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            dgv.AllowUserToAddRows = true;
            btn_CapNhatKH.Enabled = false;
            btn_XoaKH.Enabled = false;
            btn_ResetTextBox.Enabled = true;
            btn_Luu.Enabled = true;
            btn_ThemKH.Enabled = false;
            txt_IdKH.Text = string.Empty;
            txt_IdKH.Enabled = false;
            txt_IdAcc.Focus();

            sql = "select * from NGUOIDUNG where IdNguoiDung='" + txt_IdAcc.Text + "'";
            DataTable dt_NguoiDung = config.ExecuteSelectQuery(sql);
            if (dt_NguoiDung.Rows.Count == 0)
            {
                MessageBox.Show("Không có Dữ liệu tài khoản ");
                return;
            }
        }
        private void ResetValues()
        {
            txt_IdKH.Text = string.Empty;
            txt_IdAcc.Text = string.Empty;
            txt_TenKH.Text = string.Empty;
            txt_ngaysinh.Text = string.Empty;
            txt_gioitinh.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            txt_sdt.Text = string.Empty;
            txt_mail.Text = string.Empty;

        }
        private void dgv_Click(object sender, EventArgs e)
        {
            lvGiaoDich.Items.Clear();
            btn_CapNhatKH.Enabled = true;
            btn_XoaKH.Enabled = true;
            btn_ResetTextBox.Enabled = true;
        }

        private void btn_ResetTextBox_Click(object sender, EventArgs e)
        {
            ResetValues();
            btn_ResetTextBox.Enabled = false;
            btn_ThemKH.Enabled = true;
            btn_XoaKH.Enabled = true;
            btn_CapNhatKH.Enabled = true;
            btn_Luu.Enabled = false;
            txt_IdKH.Enabled = false;
            txt_IdKH.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            txt_IdKH.Enabled = false;
            if (string.IsNullOrEmpty(txt_IdAcc.Text) || string.IsNullOrEmpty(txt_TenKH.Text) || string.IsNullOrEmpty(txt_diachi.Text) || string.IsNullOrEmpty(txt_sdt.Text) || string.IsNullOrEmpty(txt_ngaysinh.Text) || string.IsNullOrEmpty(txt_gioitinh.Text) || string.IsNullOrEmpty(txt_mail.Text))
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_IdAcc.Focus();
                return;
            }
            else
            {
                string s = "select COUNT(*) from KhachHang where IdNguoiDung='" + txt_IdAcc.Text + "'";
                Object check = config.ExecuteScalar(s);
                int kq = int.Parse(check.ToString());
                if (kq <= 0)
                {
                    sql = string.Format("INSERT INTO KhachHang VALUES('{0}',N'{1}','{2}',N'{3}',N'{4}','{5}','{6}')",
                                txt_IdAcc.Text,
                                txt_TenKH.Text,
                                txt_ngaysinh.Text,
                                txt_gioitinh.Text,
                                txt_diachi.Text,
                                txt_sdt.Text,
                                txt_mail.Text);
                    config.ExecuteNonQuery(sql);
                    loadDanhSachKH();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại Mã Người Dùng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_IdAcc.Focus();
                    return;
                }
            }

            ResetValues();
            btn_XoaKH.Enabled = true;
            btn_ThemKH.Enabled = true;
            btn_CapNhatKH.Enabled = true;

            btn_Luu.Enabled = false;
            txt_IdKH.Enabled = false;
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin khách hàng?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("DELETE KhachHang WHERE IdKhachHang = {0}", txt_IdKH.Text);
                config.ExecuteNonQuery(sql);
                loadDanhSachKH();
            }
        }

        private void btn_CapNhatKH_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin khách hàng?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("UPDATE KhachHang SET TenKhachHang = N'{0}',NgaySinh='{1}' ,GioiTinh = N'{2}',DiaChi=N'{3}',SoDienThoai = '{4}',Email='{5}' WHERE IdKhachHang = {6}", txt_TenKH.Text, txt_ngaysinh.Text, txt_gioitinh.Text, txt_diachi.Text, txt_sdt.Text, txt_mail.Text, txt_IdKH.Text);
                config.ExecuteNonQuery(sql);
                loadDanhSachKH();
            }
        }

        private void btn_FindGD_Click(object sender, EventArgs e)
        {
            lvGiaoDich.Items.Clear();
            sql = "SELECT * from dbo.func_TimLichSuGiaoDich('" + txt_sdt.Text + "')";
            DataTable dtGD = config.ExecuteSelectQuery(sql);
            if (dtGD.Rows.Count > 0)
            {
                foreach (DataRow dr in dtGD.Rows)
                {
                    ListViewItem item = new ListViewItem(new[] { dr[0].ToString() });
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    lvGiaoDich.Items.Add(item);
                }
            }
        }


    }
}
