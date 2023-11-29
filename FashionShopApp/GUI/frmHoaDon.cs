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
    public partial class frmHoaDon : Form
    {
        SQLConfig config = new SQLConfig();
        string sql;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            LoadListHoaDon();

            LoadCboNhanVien();
            LoadCboChiNhanh();
            LoadCboTenSanPham();
            LoadCboIdHoaDon();
        }
        private void LoadListHoaDon()
        {
            lsv_DanhSachHoaDon.Items.Clear();
            sql = "SELECT HD.*,TenNhanVien,TenChiNhanh, dbo.func_TongTienHoaDon(IdHoaDon) AS TongTien FROM HoaDon HD INNER JOIN NhanVien NV ON HD.IdNhanVien = NV.IdNhanVien INNER JOIN ChiNhanh CN ON HD.IdChiNhanh = CN.IdChiNhanh ORDER BY IdHoaDon DESC";
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {          
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(new[] { dr[0].ToString() });
                    item.SubItems.Add(dr[6].ToString());
                    item.SubItems.Add(dr[7].ToString());
                    item.SubItems.Add(dr[3].ToString());
                    item.SubItems.Add(dr[4].ToString());
                    item.SubItems.Add(dr[5].ToString());
                    item.SubItems.Add(dr[8].ToString());
                    lsv_DanhSachHoaDon.Items.Add(item);

                }

            }
        }
        private void LoadListChiTietHoaDon(string idHoaDon)
        {
            lsv_ChiTietHoaDon.Items.Clear();
            sql = string.Format("SELECT CT.*,TenSanPham FROM ChiTietHoaDon CT INNER JOIN SanPham SP ON CT.IdSanPham = SP.IdSanPham WHERE IdHoaDon = {0}", idHoaDon);
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(new[] { dr[0].ToString() });
                    item.SubItems.Add(dr[4].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    item.SubItems.Add(dr[3].ToString());

                    lsv_ChiTietHoaDon.Items.Add(item);

                }

            }
        }
        public void LoadCboChiNhanh()
        {
            sql = "SELECT IdChiNhanh,TenChiNhanh FROM ChiNhanh";
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
        public void LoadCboNhanVien()
        {
            sql = "SELECT IdNhanVien,TenNhanVien FROM NhanVien";
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                List<object> items = new List<object>();
                foreach (DataRow dr in dt.Rows)
                {
                    items.Add(new { Text = dr[1].ToString(), Value = dr[0] });
                }

                cbo_NhanVien.DataSource = items;
                cbo_NhanVien.DisplayMember = "Text";
                cbo_NhanVien.ValueMember = "Value";
            }

            cbo_NhanVien.SelectedIndex = -1;
        }
        public void LoadCboTenSanPham()
        {
            sql = "SELECT IdSanPham, TenSanPham FROM SanPham";
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                List<object> items = new List<object>();
                foreach (DataRow dr in dt.Rows)
                {
                    items.Add(new { Text = dr[1].ToString(), Value = dr[0] });
                }

                cbo_TenSanPham.DataSource = items;
                cbo_TenSanPham.DisplayMember = "Text";
                cbo_TenSanPham.ValueMember = "Value";
            }

            cbo_TenSanPham.SelectedIndex = -1;
        }
        public void LoadCboIdHoaDon()
        {
            sql = "SELECT IdHoaDon FROM HoaDon";
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                List<object> items = new List<object>();
                foreach (DataRow dr in dt.Rows)
                {
                    items.Add(new { Text = dr[0].ToString(), Value = dr[0] });
                }

                cbo_IdHoaDon.DataSource = items;
                cbo_IdHoaDon.DisplayMember = "Text";
                cbo_IdHoaDon.ValueMember = "Value";
            }

            cbo_IdHoaDon.SelectedIndex = -1;
        }
        public void ResetHoaDon()
        {
            txt_IdHoaDon.Text = string.Empty;
            cbo_NhanVien.SelectedValue = -1;
            cbo_ChiNhanh.SelectedValue = -1;
            txt_SoDienThoai.Text = string.Empty;
            cbo_PtThanhToan.SelectedValue = -1;
            txt_TongTien.Text = string.Empty;
        }
        public void ResetChiTietHoaDon()
        {
            cbo_IdHoaDon.SelectedValue = -1;
            cbo_TenSanPham.SelectedValue = -1;
            nmud_SoLuong.Value = 0;
            txt_DonGia.Text = string.Empty;
        }
        public void XoaTatCaCtHoaDonCuaHoaDon(string idHoaDon)
        {
            sql = "DELETE ChiTietHoaDon WHERE IdHoaDon = " + idHoaDon;
            config.ExecuteNonQuery(sql);
        }
        private void btn_ResetHoaDon_Click(object sender, EventArgs e)
        {
            ResetHoaDon();
        }

        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_SoDienThoai.Text))
                sql = string.Format("INSERT INTO HoaDon VALUES({0},{1},'{2}',N'{3}',GETDATE())", cbo_NhanVien.SelectedValue, cbo_ChiNhanh.SelectedValue, txt_SoDienThoai.Text, cbo_PtThanhToan.Text);
            else
                sql = string.Format("INSERT INTO HoaDon VALUES({0},{1},null,N'{2}',GETDATE())", cbo_NhanVien.SelectedValue, cbo_ChiNhanh.SelectedValue, cbo_PtThanhToan.Text);

            config.ExecuteNonQuery(sql);
            LoadListHoaDon();
            LoadCboTenSanPham();
            LoadCboIdHoaDon();
        }

        private void btn_CapNhatHoaDon_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin loại hóa đơn?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("UPDATE HoaDon SET IdNhanVien = {0}, IdChiNhanh = {1}, SoDienThoai = '{2}', PhuongThucThanhToan = N'{3}' WHERE IdHoaDon = {4}", cbo_NhanVien.SelectedValue, cbo_ChiNhanh.SelectedValue, txt_SoDienThoai.Text, cbo_PtThanhToan.Text, txt_IdHoaDon.Text);
                config.ExecuteNonQuery(sql);
                LoadListHoaDon();
                LoadCboTenSanPham();
                LoadCboIdHoaDon();
            }
        }
        private void btn_XoaHoaDon_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                XoaTatCaCtHoaDonCuaHoaDon(txt_IdHoaDon.Text);
                sql = string.Format("DELETE HoaDon WHERE IdHoaDon =  {0}", txt_IdHoaDon.Text);
                config.ExecuteNonQuery(sql);
                LoadListHoaDon();
                LoadCboTenSanPham();
                LoadCboIdHoaDon();
            }
        }
        private void btn_ResetChiTietHoaDon_Click(object sender, EventArgs e)
        {
            ResetChiTietHoaDon();
        }

        private void btn_ThemChiTietHoaDon_Click(object sender, EventArgs e)
        {
            if (nmud_SoLuong.Value == 0)
            {
                MessageBox.Show("Số lượng phải lơn hơn 0!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql2 = string.Format("SELECT COUNT(*) FROM ChiTietHoaDon WHERE IdHoaDon = {0} AND IdSanPham = {1}", cbo_IdHoaDon.SelectedValue, cbo_TenSanPham.SelectedValue);
                object result = config.ExecuteScalar(sql2);
                int count = int.Parse(result.ToString());
                if (count > 0)
                {
                    MessageBox.Show("Sản phẩm này đã có trong đơn hàng này!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (nmud_SoLuong.Value == 0)
                    {
                        MessageBox.Show("Số lượng phải lơn hơn 0!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        sql = string.Format("INSERT INTO ChiTietHoaDon VALUES({0},{1},{2},{3})", cbo_IdHoaDon.SelectedValue, cbo_TenSanPham.SelectedValue, nmud_SoLuong.Value, txt_DonGia.Text);
                        config.ExecuteNonQuery(sql);
                        LoadListHoaDon();
                        LoadListChiTietHoaDon(cbo_IdHoaDon.Text);
                    }
                }

            }
        }

        private void btn_CapNhatChiTietHoaDon_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật chi tiết hóa đơn?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                if (nmud_SoLuong.Value == 0)
                {
                    MessageBox.Show("Số lượng phải lơn hơn 0!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sql = string.Format("UPDATE ChiTietHoaDon SET SoLuong = {0}, DonGia = {1} WHERE IdHoaDon = {2} AND IdSanPham = {3}", nmud_SoLuong.Value, txt_DonGia.Text, cbo_IdHoaDon.SelectedValue, cbo_TenSanPham.SelectedValue);
                    config.ExecuteNonQuery(sql);
                    LoadListHoaDon();
                    LoadListChiTietHoaDon(cbo_IdHoaDon.Text);
                }
            }
        }

        private void btn_XoaChiTietHoaDon_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết hóa đơn?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                sql = string.Format("DELETE ChiTietHoaDon WHERE IdHoaDon = {0} AND IdSanPham = {1}", cbo_IdHoaDon.SelectedValue, cbo_TenSanPham.SelectedValue);
                config.ExecuteNonQuery(sql);
                LoadListHoaDon();
                LoadListChiTietHoaDon(cbo_IdHoaDon.Text);
            }
        }

        private void lsv_DanhSachHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsv_DanhSachHoaDon.SelectedItems[0];

                txt_IdHoaDon.Text = selectedItem.SubItems[0].Text;
                cbo_NhanVien.Text = selectedItem.SubItems[1].Text;
                cbo_ChiNhanh.Text = selectedItem.SubItems[2].Text;
                txt_SoDienThoai.Text = selectedItem.SubItems[3].Text;
                cbo_PtThanhToan.Text = selectedItem.SubItems[4].Text;
                dtp_NgayXuatHoaDon.Text = selectedItem.SubItems[5].Text;
                txt_TongTien.Text = selectedItem.SubItems[6].Text;
                cbo_IdHoaDon.Text = selectedItem.SubItems[0].Text;
                LoadListChiTietHoaDon(selectedItem.SubItems[0].Text);
            }
            else
            {
                ResetHoaDon();
            }
        }

        private void lsv_ChiTietHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_ChiTietHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsv_ChiTietHoaDon.SelectedItems[0];

                cbo_TenSanPham.Text = selectedItem.SubItems[1].Text;
                cbo_IdHoaDon.Text = selectedItem.SubItems[0].Text;
                nmud_SoLuong.Value = int.Parse(selectedItem.SubItems[2].Text);
                txt_DonGia.Text = selectedItem.SubItems[3].Text;
            }
            else
            {
                ResetChiTietHoaDon();
            }
        }
        private void cbo_TenSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbo_TenSanPham.SelectedValue != null)
            {
                sql = string.Format("SELECT GiaBan FROM SanPham WHERE IdSanPham = {0}", cbo_TenSanPham.SelectedValue);
                DataTable dataTable = config.ExecuteSelectQuery(sql);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        txt_DonGia.Text = row[0].ToString();
                    }
                }
            }
            else
                txt_DonGia.Text = null;

        }


    }
}
