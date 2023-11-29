using FashionShopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionShopApp.GUI
{
    public partial class frmTK_KhachHang : Form
    {
        SQLConfig config = new SQLConfig();
        string sql;
        DataSet ds_tk = new DataSet();
        public frmTK_KhachHang()
        {
            InitializeComponent();
        }
        private void frmTK_KhachHang_Load(object sender, EventArgs e)
        {
            loadTKKhachHang();
            txt_IdAcc.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Reset.Enabled = false;
            txt_tenTK.Focus();
        }
        void loadTKKhachHangSearch(string sql)
        {
            //sql = "select IdNguoiDung,TenTaiKhoan,MatKhau,TonTai,Cam from NguoiDung where IdVaiTro=4";
            DataTable dt = config.ExecuteSelectQuery(sql);
            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "Mã Người dùng";
            dgv.Columns[1].HeaderText = "Tên Tài Khoản";
            dgv.Columns[2].HeaderText = "Mật Khẩu";
            dgv.Columns[3].HeaderText = "Tồn tại";
            dgv.Columns[4].HeaderText = "Khoá";
            //dgv.AllowUserToAddRows = false;
        }
        void loadTKKhachHang()
        {
            sql = "select IdNguoiDung,TenTaiKhoan,MatKhau,TonTai,Cam from NguoiDung where IdVaiTro=4";
            DataTable dt = config.ExecuteSelectQuery(sql);
            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "Mã Người dùng";
            dgv.Columns[1].HeaderText = "Tên Tài Khoản";
            dgv.Columns[2].HeaderText = "Mật Khẩu";
            dgv.Columns[3].HeaderText = "Tồn tại";
            dgv.Columns[4].HeaderText = "Khoá";
            dgv.AllowUserToAddRows = false;
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenTK.Text) || string.IsNullOrEmpty(txt_matkhau.Text) )
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_IdAcc.Focus();
                return;
            }
            string s = "select COUNT(*) from KhachHang where IdNguoiDung='" + txt_IdAcc.Text + "'";
            Object check = config.ExecuteScalar(s);
            int kq = int.Parse(check.ToString());
            if (kq <= 0)
            {
                sql = string.Format("INSERT INTO NguoiDung VALUES('{0}','{1}',4,1,0)",
                            txt_tenTK.Text,
                            txt_matkhau.Text);
                config.ExecuteNonQuery(sql);
                loadTKKhachHang();
            }
            else
            {
                MessageBox.Show("Đã tồn tại Mã Người Dùng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_IdAcc.Focus();
                return;
            }
            ResetValues();
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_CapNhat.Enabled = true;

            btn_Luu.Enabled = false;
            txt_IdAcc.Enabled = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            dgv.AllowUserToAddRows = true;
            btn_CapNhat.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Reset.Enabled = true;
            btn_Luu.Enabled = true;
            btn_Them.Enabled = false;
            txt_IdAcc.Text = string.Empty;
            txt_IdAcc.Enabled = false;
            txt_tenTK.Focus();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin Tài Khoản khách hàng?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                string s = "select COUNT(*) from KhachHang where IdNguoiDung='" + txt_IdAcc.Text + "'";
                Object check = config.ExecuteScalar(s);
                int kq = int.Parse(check.ToString());
                if (kq > 0)
                {
                    MessageBox.Show("Không thể xoá Người Dùng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_IdAcc.Focus();
                    return;
                }
                else
                {
                    sql = string.Format("DELETE NguoiDung WHERE IdNguoiDung = {0}", txt_IdAcc.Text);
                    config.ExecuteNonQuery(sql);
                    loadTKKhachHang();
                }    
                    
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin Tài Khoản khách hàng?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("UPDATE NguoiDung SET TenTaiKhoan = '{0}',MatKhau='{1}'  WHERE IdNguoiDung = {2}", txt_tenTK.Text, txt_matkhau.Text,txt_IdAcc.Text);
                config.ExecuteNonQuery(sql);
                loadTKKhachHang();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetValues();
            loadTKKhachHang();
        }
        void ResetValues()
        {
            txt_IdAcc.Text = string.Empty;
            txt_tenTK.Text = string.Empty;
            txt_matkhau.Text = string.Empty;
        }
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                txt_IdAcc.Text = dgv.Rows[index].Cells[0].Value.ToString();
                txt_tenTK.Text = dgv.Rows[index].Cells[1].Value.ToString();
                txt_matkhau.Text = dgv.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void btn_SearchTK_Click(object sender, EventArgs e)
        {
            sql = "select IdNguoiDung,TenTaiKhoan,MatKhau,TonTai,Cam from NguoiDung where IdVaiTro=4 and TenTaiKhoan='" + txt_tenTK.Text + "'";
            DataTable dt_NguoiDung = config.ExecuteSelectQuery(sql);
            loadTKKhachHangSearch(sql);
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            btn_CapNhat.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Reset.Enabled = true;
        }
    }
}
