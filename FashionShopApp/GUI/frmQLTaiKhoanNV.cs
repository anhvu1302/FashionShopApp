using FashionShopApp.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace FashionShopApp.GUI
{
    public partial class frmQLTaiKhoanNV : Form
    {
        SQLConfig config = new SQLConfig(NguoiDungHienTai.CurentUser.nguoiDung.TenTaiKhoan, NguoiDungHienTai.CurentUser.nguoiDung.MatKhau);
        string sql;

        public frmQLTaiKhoanNV()
        {
            InitializeComponent();
        }
        void loadTKNhanVien()
        {
            sql = "select *from dbo.func_ShowTaiKhoanNV()";
            DataTable dt = config.ExecuteSelectQuery(sql);
            dgv.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dgv.Columns[0].HeaderText = "Mã Người dùng";
                dgv.Columns[1].HeaderText = "Tên Tài Khoản";
                dgv.Columns[2].HeaderText = "Mật Khẩu";
                dgv.Columns[3].HeaderText = "Vai Trò";
                dgv.Columns[4].HeaderText = "Tồn tại";
                dgv.Columns[5].HeaderText = "Cấm";
            }
            dgv.AllowUserToAddRows = false;
        }
        void loadCboVaiTro()
        {
            string s = "select * from VaiTro where (IdVaiTro!=4 And IdVaiTro!=1) or (TenVaiTro!=N'Admin' And TenVaiTro!=N'Khách hàng') ";
            DataTable dt = config.ExecuteSelectQuery(s);
            if (dt.Rows.Count > 0)
            {
                List<object> items = new List<object>();
                foreach (DataRow dr in dt.Rows)
                {
                    items.Add(new { Text = dr[1].ToString(), Value = dr[0] });
                }
                cb_vaiTro.DataSource = items;
                cb_vaiTro.DisplayMember = "Text";
                cb_vaiTro.ValueMember = "Value";
            }

            cb_vaiTro.SelectedIndex = -1;

        }
        //private void frmTK_NhanVien_Load(object sender, EventArgs e)
        //{
        //    loadTKNhanVien();
        //    txt_IdAcc.Enabled = false;
        //    btn_Luu.Enabled = false;
        //    btn_Reset.Enabled = false;
        //    txt_tenTK.Focus();
        //}
        void loadTKNhanVienSearch(string sql)
        {
            //sql = "select IdNguoiDung,TenTaiKhoan,MatKhau,TonTai,Cam from NguoiDung where IdVaiTro=4";
            DataTable dt = config.ExecuteSelectQuery(sql);
            dgv.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                dgv.Columns[0].HeaderText = "Mã Người dùng";
                dgv.Columns[1].HeaderText = "Tên Tài Khoản";
                dgv.Columns[2].HeaderText = "Mật Khẩu";
                dgv.Columns[3].HeaderText = "Vai Trò";
                dgv.Columns[4].HeaderText = "Tồn tại";
                dgv.Columns[5].HeaderText = "Cấm";
            }
            //dgv.AllowUserToAddRows = false;
        }

        private void frmQLTaiKhoanNV_Load(object sender, EventArgs e)
        {
            loadTKNhanVien();
            loadCboVaiTro();
            txt_IdAcc.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Reset.Enabled = false;
            txt_tenTK.Focus();
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

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tenTK.Text) || string.IsNullOrEmpty(txt_matkhau.Text))
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_IdAcc.Focus();
                return;
            }
            string s = "select COUNT(*) from NhanVien where IdNguoiDung='" + txt_IdAcc.Text + "'";
            Object check = config.ExecuteScalar(s);
            int kq = int.Parse(check.ToString());
            if (kq <= 0)
            {
                sql = string.Format("exec ThemNguoiDungNhanVien '{0}','{1}','{2}'",
                            txt_tenTK.Text,
                            txt_matkhau.Text,
                            cb_vaiTro.SelectedValue.ToString());
                config.ExecuteNonQuery(sql);
                loadTKNhanVien();
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
        void ResetValues()
        {
            txt_IdAcc.Text = string.Empty;
            txt_tenTK.Text = string.Empty;
            txt_matkhau.Text = string.Empty;
            cb_vaiTro.SelectedIndex = -1;
            chk_Ban.Checked = false;
            chk_tontai.Checked = false;
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin Tài Khoản ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("UPDATE NguoiDung SET MatKhau='{0}',TonTai='{1}',Cam='{2}',IdVaiTro='{3}'  WHERE IdNguoiDung = {4}", txt_matkhau.Text, chk_tontai.Checked, chk_Ban.Checked,cb_vaiTro.SelectedValue.ToString(), txt_IdAcc.Text);
                config.ExecuteNonQuery(sql);
                loadTKNhanVien();
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin Tài Khoản?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                string s = "select COUNT(*) from NhanVien where IdNguoiDung='" + txt_IdAcc.Text + "'";
                Object check = config.ExecuteScalar(s);
                int kq = int.Parse(check.ToString());
                if (kq > 0)
                {
                    MessageBox.Show("Không thể xoá Người Dùng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_tenTK.Focus();
                    return;
                }
                else
                {
                    sql = string.Format("exec XoaTaiKhoanNV '{0}','{1}'", txt_tenTK.Text, cb_vaiTro.SelectedValue.ToString());
                    config.ExecuteNonQuery(sql);
                    loadTKNhanVien();
                }

            }
        }

        private void btn_SearchTK_Click(object sender, EventArgs e)
        {
            sql = "select *from dbo.func_FindTaiKhoanNV('"+ txt_tenTK.Text+ "')" ;
            DataTable dt_NguoiDung = config.ExecuteSelectQuery(sql);
            loadTKNhanVienSearch(sql);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                txt_IdAcc.Text = dgv.Rows[index].Cells[0].Value.ToString();
                txt_tenTK.Text = dgv.Rows[index].Cells[1].Value.ToString();
                txt_matkhau.Text = dgv.Rows[index].Cells[2].Value.ToString();
                cb_vaiTro.Text = dgv.Rows[index].Cells[3].Value.ToString();
                chk_tontai.Checked = Convert.ToBoolean(dgv.Rows[index].Cells[4].Value.ToString());
                chk_Ban.Checked = Convert.ToBoolean(dgv.Rows[index].Cells[5].Value.ToString());
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetValues();
            loadTKNhanVien();
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            btn_CapNhat.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Reset.Enabled = true;
            
        }
    }
}
