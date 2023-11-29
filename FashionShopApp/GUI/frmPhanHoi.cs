using FashionShopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionShopApp
{
    public partial class frmPhanHoi : Form
    {
        SQLConfig config = new SQLConfig();
        string sql;
        public frmPhanHoi()
        {
            InitializeComponent();
        }
        void loadDanhSachPhanHoi()
        {
            sql = "SELECT IdPhanHoi,KhachHang.IdKhachHang,TenKhachHang,PhanHoi.SoDienThoai,VanDe, NoiDungVanDe,PhanHoi.ThoiGianPhanHoi \r\nFROM PhanHoi\r\ninner join KhachHang on KhachHang.IdKhachHang=PhanHoi.IdKhachHang ";
            DataTable dt = config.ExecuteSelectQuery(sql);

            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "Mã Phản hồi";
            dgv.Columns[1].HeaderText = "Mã Khách Hàng";
            dgv.Columns[2].HeaderText = "Tên Khách Hàng";
            dgv.Columns[3].HeaderText = "Số điện thoại";
            dgv.Columns[4].HeaderText = "Vấn đề";
            dgv.Columns[5].HeaderText = "Nội dung vấn đề";
            dgv.Columns[6].HeaderText = "Thời gian gửi phản hồi";
            dgv.AllowUserToAddRows = false;
        }
        void loadPhanHoi()
        {
            sql = "SELECT IdPhanHoi,KhachHang.IdKhachHang,TenKhachHang,PhanHoi.SoDienThoai,VanDe, NoiDungVanDe,PhanHoi.ThoiGianPhanHoi \r\nFROM PhanHoi\r\ninner join KhachHang on KhachHang.IdKhachHang=PhanHoi.IdKhachHang where PhanHoi.IdKhachHang='"+txt_makh.Text+"'";
            DataTable dt = config.ExecuteSelectQuery(sql);

            dgv.DataSource = dt;
            dgv.Columns[0].HeaderText = "Mã Phản hồi";
            dgv.Columns[1].HeaderText = "Mã Khách Hàng";
            dgv.Columns[2].HeaderText = "Tên Khách Hàng";
            dgv.Columns[3].HeaderText = "Số điện thoại";
            dgv.Columns[4].HeaderText = "Vấn đề";
            dgv.Columns[5].HeaderText = "Nội dung vấn đề";
            dgv.Columns[6].HeaderText = "Thời gian gửi phản hồi";
            dgv.AllowUserToAddRows = false;
        }
        private void frmPhanHoiKH_Load(object sender, EventArgs e)
        {
            txt_makh.Focus();
            txt_maPhanHoi.Enabled = false;
            loadDanhSachPhanHoi();
            txt_tenKH.Enabled = false;
            dtp_phanhoi.Enabled = false;
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn thu hổi phản hồi?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("DELETE PhanHoi WHERE IdPhanHoi = {0}", txt_maPhanHoi.Text);
                config.ExecuteNonQuery(sql);
                loadDanhSachPhanHoi();
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật phản hồi?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("UPDATE PhanHoi SET SoDienThoai='{0}' ,VanDe = N'{1}',NoiDungVanDe=N'{2}',ThoiGianPhanHoi = Getdate() WHERE IdPhanHoi = {4} ", txt_sdt.Text, cboVanDe.Text, r_NDVanDe.Text, dtp_phanhoi.Text,  txt_maPhanHoi.Text);
                config.ExecuteNonQuery(sql);
                loadDanhSachPhanHoi();
            }
        }


        private void btn_ResetTextBox_Click(object sender, EventArgs e)
        {
            txt_maPhanHoi.Text = string.Empty;
            txt_makh.Text = string.Empty;
            txt_tenKH.Text = string.Empty;
            txt_sdt.Text = string.Empty;
            cboVanDe.Text = string.Empty;
            r_NDVanDe.Text = string.Empty;
            dtp_phanhoi.Text = string.Empty;
            loadDanhSachPhanHoi() ;
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            loadPhanHoi();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                txt_maPhanHoi.Text=dgv.Rows[index].Cells[0].Value.ToString();
                txt_makh.Text = dgv.Rows[index].Cells[1].Value.ToString();
                txt_tenKH.Text = dgv.Rows[index].Cells[2].Value.ToString();
                txt_sdt.Text = dgv.Rows[index].Cells[3].Value.ToString();
                cboVanDe.Text = dgv.Rows[index].Cells[4].Value.ToString();
                r_NDVanDe.Text = dgv.Rows[index].Cells[5].Value.ToString();
                dtp_phanhoi.Text = dgv.Rows[index].Cells[6].Value.ToString();
            }
        }

        private void btn_RsRichtxt_Click(object sender, EventArgs e)
        {
            r_NDVanDe.ResetText();
        }

        private void btn_Gui_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_makh.Text) || string.IsNullOrEmpty(txt_sdt.Text) || string.IsNullOrEmpty(btn_RsRichtxt.Text) || string.IsNullOrEmpty(cboVanDe.Text) )
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_makh.Focus();
                return;
            }
            else
            {
                sql = string.Format("INSERT INTO PhanHoi VALUES('{0}','{1}',N'{2}',N'{3}',Getdate())",
                                txt_makh.Text,
                                txt_sdt.Text,
                                cboVanDe.Text,
                                r_NDVanDe.Text
                                
                               );
                config.ExecuteNonQuery(sql);
                loadDanhSachPhanHoi();
            }    
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            btn_Xoa.Enabled = true;
            btn_CapNhat.Enabled = true;
        }

        private void txt_makh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
