using FashionShopApp.Model;
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

namespace FashionShopApp.GUI
{
    public partial class frmKhachHang : Form
    {
        SQLConfig config = new SQLConfig();
        string sql;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            loadDanhSachKH();
        }
        void loadDanhSachKH()
        {
            sql = "SELECT *FROM KhachHang";
            DataTable dt = config.ExecuteSelectQuery(sql);
            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "Mã KH";
            dgv.Columns[1].HeaderText = "Mã Tài Khoản";
            dgv.Columns[2].HeaderText = "Tên Khách Hàng";
            dgv.Columns[3].HeaderText = "Ngày sinh";
            dgv.Columns[4].HeaderText = "Giới tính";
            dgv.Columns[5].HeaderText = "Địa chỉ";
            dgv.Columns[6].HeaderText = "Số Đt";
            dgv.Columns[7].HeaderText = "Email";
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

        private void btn_ResetLoaiSpCha_Click(object sender, EventArgs e)
        {
            txt_IdKH.Text= string.Empty;
            txt_IdAcc.Text = string.Empty;
            txt_TenKH.Text = string.Empty;
            txt_ngaysinh.Text = string.Empty;
            txt_gioitinh.Text = string.Empty;
            txt_diachi.Text = string.Empty;
            txt_sdt.Text = string.Empty;
            txt_mail.Text = string.Empty;
            txt_IdKH.Focus();
        }

        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            if (/*txt_IdKH.Text == string.Empty ||*/ txt_TenKH.Text == string.Empty ||txt_IdAcc.Text==string.Empty)
            {
                MessageBox.Show("Chưa nhập dữ liệu");
                return;
            }
            else
            {
                try
                {
                    
                    string s = "select COUNT(*) from KhachHang where IdNguoiDung='" + txt_IdAcc.Text + "'";
                    if (config.checkkey(s) == true)
                    {
                        string sql = string.Format("INSERT INTO KhachHang VALUES('{0}',N'{1}','{2}',N'{3}',N'{4}','{5}','{6}')", 
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
                        MessageBox.Show("Trùng khóa");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
                finally
                {
                    //config.Close();
                }
            }
        }
    }
}
