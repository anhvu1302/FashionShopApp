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
    public partial class frmLoaiSanPham : Form
    {
        SQLConfig config = new SQLConfig(NguoiDungHienTai.CurentUser.nguoiDung.TenTaiKhoan, NguoiDungHienTai.CurentUser.nguoiDung.MatKhau);
        string sql;
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadListLoaiSanPhamCha();
            LoadListLoaiSanPham();
            LoadCboLoaiSanPhamCha();
        }
        public void LoadCboLoaiSanPhamCha()
        {
            sql = "SELECT * FROM LoaiSanPhamCha";
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                List<object> items = new List<object>();
                foreach (DataRow dr in dt.Rows)
                {
                    items.Add(new { Text = dr[1].ToString(), Value = dr[0] });
                }

                cbo_LoaiSanPhamCha.DataSource = items;
                cbo_LoaiSanPhamCha.DisplayMember = "Text";
                cbo_LoaiSanPhamCha.ValueMember = "Value";
            }

            cbo_LoaiSanPhamCha.SelectedIndex = -1;
        }
        public void LoadListLoaiSanPhamCha()
        {
            lsv_LoaiSanPhamCha.Items.Clear();
            sql = "SELECT * FROM LoaiSanPhamCha ORDER BY IdLoaiSPCha DESC";
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {               
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(new[] { dr[0].ToString() });
                    item.SubItems.Add(dr[1].ToString());
                    lsv_LoaiSanPhamCha.Items.Add(item);
                }

            }
        }
        public void LoadListLoaiSanPham()
        {
            lsv_LoaiSanPham.Items.Clear();
            sql = "SELECT A.*, TenLoaiSPCha FROM LoaiSanPham A INNER JOIN LoaiSanPhamCha B ON A.IdLoaiSPCha = B.IdLoaiSPCha ORDER BY IdLoaiSP DESC";
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(new[] { dr[0].ToString() });
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[3].ToString());
                    lsv_LoaiSanPham.Items.Add(item);
                }

            }
        }
        private void btn_ResetLoaiSpCha_Click(object sender, EventArgs e)
        {
            ResetLoaiSanPhamCha();
        }
        private void ResetLoaiSanPhamCha()
        {
            txt_IdLoaiSanPhamCha.Text = string.Empty;
            txt_TenLoaiSanPhamCha.Text = string.Empty;
        }
        private void btn_ThemLoaiSpCha_Click(object sender, EventArgs e)
        {
            if(txt_TenLoaiSanPhamCha.Text.Length > 0)
            {
                sql = string.Format("INSERT INTO LoaiSanPhamCha VALUES (N'{0}')", txt_TenLoaiSanPhamCha.Text);
                if (config.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("Thêm sản phẩm loại cha thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm loại cha không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadListLoaiSanPhamCha();
            }
            else
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm cha", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_CapNhatLoaiSpCha_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin loại sản phẩm cha?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("UPDATE LoaiSanPhamCha SET TenLoaiSPCha = N'{0}' WHERE IdLoaiSPCha = {1}", txt_TenLoaiSanPhamCha.Text, txt_IdLoaiSanPhamCha.Text);
                if (config.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("Cập nhập thông tin sản phẩm loại cha thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhập thông tin sản phẩm loại cha không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadListLoaiSanPhamCha();
            }
        }
        private void btn_XoaLoaiSpCha_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin loại sản phẩm cha?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("DELETE LoaiSanPhamCha WHERE IdLoaiSPCha = {0}", txt_IdLoaiSanPhamCha.Text);
                if (config.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("Xoá thông tin sản phẩm loại cha thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xoá thông tin sản phẩm loại cha không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadListLoaiSanPhamCha();
            }
        }
        private void btn_ResetLoaiSp_Click(object sender, EventArgs e)
        {
            ResetLoaiSanPham();
        }
        private void ResetLoaiSanPham()
        {
            txt_IdLoaiSanPham.Text = string.Empty;
            txt_TenLoaiSanPham.Text = string.Empty;
            cbo_LoaiSanPhamCha.SelectedValue = -1;
        }
        private void btn_ThemLoaiSp_Click(object sender, EventArgs e)
        {
            if (txt_TenLoaiSanPham.Text.Length > 0)
            {
                sql = string.Format("INSERT INTO LoaiSanPham VALUES (N'{0}',{1})", txt_TenLoaiSanPham.Text,cbo_LoaiSanPhamCha.SelectedValue);
                config.ExecuteNonQuery(sql);
                if (config.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("Thêm loại sản phẩm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm loại sản phẩm không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadListLoaiSanPham();
            }
            else
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btn_CapNhatLoaiSp_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin loại sản phẩm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("UPDATE LoaiSanPham SET TenLoaiSP = N'{0}', IdLoaiSpCha = {1} WHERE IdLoaiSP = {2}", txt_TenLoaiSanPham.Text, cbo_LoaiSanPhamCha.SelectedValue, txt_IdLoaiSanPham.Text);
                if (config.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("Cập nhật loại sản phẩm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật loại sản phẩm không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadListLoaiSanPhamCha();
            }
        }
        private void btn_XoaLoaiSp_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn xóa thông tin loại sản phẩm?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("DELETE LoaiSanPham WHERE IdLoaiSP = {0}", txt_IdLoaiSanPham.Text);
                if (config.ExecuteNonQuery(sql))
                {
                    MessageBox.Show("Xoá loại sản phẩm thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xoá loại sản phẩm không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadListLoaiSanPham();
            }
        }

        private void lsv_LoaiSanPhamCha_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_LoaiSanPhamCha.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsv_LoaiSanPhamCha.SelectedItems[0];
                txt_IdLoaiSanPhamCha.Text = selectedItem.SubItems[0].Text;
                txt_TenLoaiSanPhamCha.Text = selectedItem.SubItems[1].Text;

            }
            else
            {
                ResetLoaiSanPhamCha();
            }
        }

        private void lsv_LoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_LoaiSanPham.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsv_LoaiSanPham.SelectedItems[0];
                txt_IdLoaiSanPham.Text = selectedItem.SubItems[0].Text;
                txt_TenLoaiSanPham.Text = selectedItem.SubItems[1].Text;
                cbo_LoaiSanPhamCha.Text = selectedItem.SubItems[2].Text;

            }
            else
            {
                ResetLoaiSanPham();
            }
        }


    }
}
