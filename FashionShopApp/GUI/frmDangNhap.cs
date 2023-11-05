using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FashionShopApp.Model;
namespace FashionShopApp
{
    public partial class frmDangNhap : Form
    {
        SQLConfig config = new SQLConfig();
        static string sql;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void txt_Username_Click(object sender, EventArgs e)
        {
            txt_Username.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = SystemColors.Control;
            txt_Password.BackColor = SystemColors.Control;
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txt_Username.BackColor = SystemColors.Control;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text.Length > 0)
            {
                if (txt_Password.Text.Length > 0)
                {
                    sql = "SELECT COUNT(*) FROM NguoiDung WHERE TenTaiKhoan = '" + txt_Username.Text + "' AND MatKhau = '" + txt_Password.Text + "'";
                    Object result = config.ExecuteScalar(sql);
                    if (int.Parse(result.ToString()) > 0)
                    {
                        string sql2 = " SELECT * FROM NguoiDung N INNER JOIN VAITRO V ON N.IdVaiTro = V.IdVaiTro WHERE TenTaiKhoan = '" + txt_Username.Text + "' AND MatKhau = '" + txt_Password.Text + "'";
                        DataTable dataTable = config.ExecuteSelectQuery(sql2);
                        if (dataTable.Rows.Count > 0)
                        {
                            foreach (DataRow row in dataTable.Rows)
                            {
                                NguoiDungHienTai.CurentUser.nguoiDung.IdNguoiDung = int.Parse(row[0].ToString());
                                NguoiDungHienTai.CurentUser.nguoiDung.TenTaiKhoan = row[1].ToString();
                                NguoiDungHienTai.CurentUser.nguoiDung.IdVaiTro = int.Parse(row[3].ToString());
                                NguoiDungHienTai.CurentUser.nguoiDung.TonTai = bool.Parse(row[4].ToString());
                                NguoiDungHienTai.CurentUser.nguoiDung.Cam = bool.Parse(row[5].ToString());
                                NguoiDungHienTai.CurentUser.tenVaiTro = row[7].ToString();
                            }
                        }

                        if (NguoiDungHienTai.CurentUser.tenVaiTro == "Khách hàng")
                        {
                            MessageBox.Show("Bạn không có quyền truy cập vào hệ thống này.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (NguoiDungHienTai.CurentUser.nguoiDung.TonTai == true)
                            {
                                if (NguoiDungHienTai.CurentUser.nguoiDung.Cam == false)
                                {
                                    frmMain frm = new frmMain();
                                    frm.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Tài khoản đã bị cấm! Vui lòng liên hệ quản trị viên.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Tài khoản đã bị xóa! Vui lòng liên hệ quản trị viên.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại! Vui lòng liên hệ quản trị viên.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txt_Username.Focus();
        }

        private void txt_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn chặn hiển thị ký tự Enter trong TextBox
                btn_Login_Click(sender, e);
            }
        }
    }
}
