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
    public partial class frmKho : Form
    {
        SQLConfig config = new SQLConfig(NguoiDungHienTai.CurentUser.nguoiDung.TenTaiKhoan, NguoiDungHienTai.CurentUser.nguoiDung.MatKhau);
        string sql;
        public frmKho()
        {
            InitializeComponent();
        }
        public void LoadCboChiNhanh()
        {
            sql = "SELECT IdChiNhanh,TenChiNhanh FROM ChiNhanh order by IdChiNhanh ASC";
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                List<object> items = new List<object>();
                foreach (DataRow dr in dt.Rows)
                {
                    items.Add(new { Text = dr[1].ToString(), Value = dr[0] });
                }
                cbo_ChiNhanh.DataSource = items;
                cbo_ChiNhanh.DisplayMember = "Text";
                cbo_ChiNhanh.ValueMember = "Value";
            }
            cbo_ChiNhanh.SelectedIndex = -1;

        }

        private void frmNhapKho_Load(object sender, EventArgs e)
        {
            
            LoadCboChiNhanh();
           
        }
        
        private void LoadDsSanPhamKhoTheoChiNhanh(string maChiNhanh)
        {
            lsv_DsSanPhamKho.Items.Clear();
            sql = "SELECT * FROM dbo.func_DsSanPhamKhoTheoChiNhanh('" + maChiNhanh + "') ORDER BY IdSanPham DESC";
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(new[] { dr[0].ToString() });
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    

                    lsv_DsSanPhamKho.Items.Add(item);
                }
            }
        }

        private void cbo_ChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbo_ChiNhanh.SelectedIndex != -1)
            {
                if (!cbo_ChiNhanh.SelectedValue.ToString().Contains("{") || string.IsNullOrEmpty(cbo_ChiNhanh.Text))
                    LoadDsSanPhamKhoTheoChiNhanh(cbo_ChiNhanh.SelectedValue.ToString());
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if(cbo_ChiNhanh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn chi nhánh!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if(string.IsNullOrEmpty(txt_TenSanPham.Text))
            {
                MessageBox.Show("Vui nhập giá trị tìm kiếm!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lsv_DsSanPhamKho.Items.Clear();
                sql = "SELECT * FROM dbo.func_FindSanPhamTheoChiNhanh('" + cbo_ChiNhanh.SelectedValue + "',N'" + txt_TenSanPham.Text + "')";
                DataTable dtGD = config.ExecuteSelectQuery(sql);
                if (dtGD.Rows.Count > 0)
                {
                    foreach (DataRow dr in dtGD.Rows)
                    {
                        ListViewItem item = new ListViewItem(new[] { dr[0].ToString() });
                        item.SubItems.Add(dr[1].ToString());
                        item.SubItems.Add(dr[2].ToString());
                        lsv_DsSanPhamKho.Items.Add(item);
                    }
                }
            }    

        }
    }
}
