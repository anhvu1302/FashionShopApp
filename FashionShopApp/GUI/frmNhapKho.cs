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
    public partial class frmNhapKho : Form
    {
        SQLConfig config = new SQLConfig(NguoiDungHienTai.CurentUser.nguoiDung.TenTaiKhoan, NguoiDungHienTai.CurentUser.nguoiDung.MatKhau);
        string sql;
        public frmNhapKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            dtp_NgayXuatHoaDon.Format = DateTimePickerFormat.Custom;
            dtp_NgayXuatHoaDon.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            LoadCboChiNhanh();
            LoadCboNhanVien();
            LoadListHoaDonNhap();
            LoadCboIdHoaDonNhap();
            LoadCboTenSanPham();
            frmMain frmMain = new frmMain();
            cbo_NhanVien.Text = frmMain.TenNguoiDungHienTai();
        }
        public void LoadCboIdHoaDonNhap()
        {
            sql = "select IdHoaDonNhapKho from HoaDonNhapKho";
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
        private void LoadListHoaDonNhap()
        {
            lsv_DsHdNhap.Items.Clear();
            sql = "SELECT * FROM dbo.func_DsHoaDonNhapKho() ORDER BY IdHoaDonNhapKho DESC";
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(new[] { dr[0].ToString() });
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[2].ToString());
                    item.SubItems.Add(dr[3].ToString());

                    lsv_DsHdNhap.Items.Add(item);
                }
            }
        }
        public void ResetHoaDonNhap()
        {
            txt_IdHoaDon.Text = string.Empty;
            cbo_NhanVien.SelectedValue = -1;
            cbo_ChiNhanh.SelectedValue = -1;
            dtp_NgayXuatHoaDon.Text = string.Empty;
        }
        public void ResetChiTietHoaDonNhap()
        {
            cbo_IdHoaDon.SelectedValue = -1;
            cbo_TenSanPham.SelectedValue = -1;
            nmud_SoLuong.Value = 0;
        }
        private void lsv_DsHdNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DsHdNhap.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsv_DsHdNhap.SelectedItems[0];

                txt_IdHoaDon.Text = selectedItem.SubItems[0].Text;
                dtp_NgayXuatHoaDon.Text = selectedItem.SubItems[1].Text;
                cbo_NhanVien.Text = selectedItem.SubItems[2].Text;
                cbo_ChiNhanh.Text = selectedItem.SubItems[3].Text;
                cbo_IdHoaDon.Text = selectedItem.SubItems[0].Text;
                LoadListChiTietHoaDon(selectedItem.SubItems[0].Text);
            }
            else
            {
                ResetHoaDonNhap();
            }
        }

        private void btn_ResetHoaDon_Click(object sender, EventArgs e)
        {
            ResetHoaDonNhap();
        }

        private void btn_ThemHoaDon_Click(object sender, EventArgs e)
        {
            bool checkNv = cbo_NhanVien.SelectedIndex != -1;
            bool checkCn = cbo_ChiNhanh.SelectedIndex != -1;

            if (!checkNv)
            {
                MessageBox.Show("Vui lòng chọn nhân viên", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!checkCn)
            {
                MessageBox.Show("Vui lòng chọn chi nhánh", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@IdNhanVien", cbo_NhanVien.SelectedValue),
                    new SqlParameter("@IdChiNhanh", cbo_ChiNhanh.SelectedValue)
                };
                bool success = config.ExecuteStoredProcedure("sp_ThemHoaDonNhapKho", parameters);

                if (!success)
                {
                    MessageBox.Show("Thêm hoá đơn nhập không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadListHoaDonNhap();
            }

        }

        private void btn_CapNhatHoaDon_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật thông tin hóa đơn nhập?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@IdHoaDonNhapKho", txt_IdHoaDon.Text),
                    new SqlParameter("@NgayNhap", dtp_NgayXuatHoaDon.Text),
                    new SqlParameter("@IdNhanVien", cbo_NhanVien.SelectedValue),
                    new SqlParameter("@IdChiNhanh", cbo_ChiNhanh.SelectedValue)
                };
                bool success = config.ExecuteStoredProcedure("sp_SuaHoaDonNhapKho", parameters);
                if (!success)
                {
                    MessageBox.Show("Thêm hoá đơn nhập không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadListHoaDonNhap();
            }
        }

        private void btn_XoaHoaDon_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn nhập?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                XoaTatCaCthdCuaHd(txt_IdHoaDon.Text);
                SqlParameter[] parameters = {
                    new SqlParameter("@IdHoaDonNhapKho", txt_IdHoaDon.Text),                };
                bool success = config.ExecuteStoredProcedure("sp_XoaHoaDonNhapKho", parameters);
                if (!success)
                {
                    MessageBox.Show("Xoá hoá đơn nhập không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadListHoaDonNhap();
            }
        }
        public void XoaTatCaCthdCuaHd(string idHoaDonNhap)
        {

            SqlParameter[] parameters = {
                new SqlParameter("@IdHoaDonNhapKho", idHoaDonNhap)
            };
            bool success = config.ExecuteStoredProcedure("sp_XoaChiTietHoaDonNhapKho", parameters);
        }


        private void LoadListChiTietHoaDon(string idHoaDon)
        {
            lsv_ChiTietHoaDon.Items.Clear();
            sql = string.Format("select * from dbo.func_DsCtHdNhapTheoIdHd({0})", idHoaDon);
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {


                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(new[] { dr[0].ToString() });
                    item.SubItems.Add(dr[1].ToString());
                    item.SubItems.Add(dr[2].ToString());

                    lsv_ChiTietHoaDon.Items.Add(item);

                }

            }
        }
        private void btn_ThemChiTietHoaDon_Click(object sender, EventArgs e)
        {
            bool checkSp = cbo_NhanVien.SelectedIndex != -1;
            bool checkHd = cbo_ChiNhanh.SelectedIndex != -1;
            bool checkSl = nmud_SoLuong.Value != 0;
            if (!checkSp)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!checkHd)
            {
                MessageBox.Show("Vui lòng chọn mã hoá đơn nhập!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(!checkSl)
            {
                MessageBox.Show("Số lượng phải lơn hơn 0!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sql2 = string.Format("select COUNT(*) from ChiTietHoaDonNhapKho WHERE IdHoaDonNhapKho = {0} AND IdSanPham = {1}", cbo_IdHoaDon.SelectedValue, cbo_TenSanPham.SelectedValue);
                object result = config.ExecuteScalar(sql2);
                int count = int.Parse(result.ToString());
                if (count > 0)
                {
                    MessageBox.Show("Sản phẩm này đã có trong đơn hàng này!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlParameter[] parameters = {
                        new SqlParameter("@IdHoaDonNhapKho", cbo_IdHoaDon.SelectedValue),
                        new SqlParameter("@IdSanPham", cbo_TenSanPham.SelectedValue),
                        new SqlParameter("@SoLuong", nmud_SoLuong.Value)
                    };
                    bool success = config.ExecuteStoredProcedure("sp_ThemChiTietHoaDonNhapKho", parameters);

                    if (!success)
                    {
                        MessageBox.Show("Thêm hoá đơn nhập không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadListHoaDonNhap();
                    LoadListChiTietHoaDon(cbo_IdHoaDon.Text);
                }    
                
            }
        }

        private void lsv_ChiTietHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_ChiTietHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lsv_ChiTietHoaDon.SelectedItems[0];

                cbo_IdHoaDon.Text = selectedItem.SubItems[0].Text;
                cbo_TenSanPham.Text = selectedItem.SubItems[1].Text;
                nmud_SoLuong.Value = long.Parse(selectedItem.SubItems[2].Text);

            }
            else
            {
                ResetChiTietHoaDonNhap();
            }
        }

        private void btn_CapNhatChiTietHoaDon_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn cập nhật chi tiết hóa đơn nhập?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                if (nmud_SoLuong.Value == 0)
                {
                    MessageBox.Show("Số lượng phải lơn hơn 0!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlParameter[] parameters = {
                        new SqlParameter("@IdHoaDonNhapKho", cbo_IdHoaDon.SelectedValue),
                        new SqlParameter("@IdSanPham", cbo_TenSanPham.SelectedValue),
                        new SqlParameter("@SoLuong", nmud_SoLuong.Value)

                    };
                    bool success = config.ExecuteStoredProcedure("sp_SuaChiTietHoaDonNhapKho", parameters);

                    if (!success)
                    {
                        MessageBox.Show("Cập nhật chi tiết hoá đơn nhập không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadListHoaDonNhap();
                    LoadListChiTietHoaDon(cbo_IdHoaDon.Text);
                }
            }
        }

        private void btn_XoaChiTietHoaDon_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Bạn có chắc chắn muốn xóa chi tiết hóa đơn nhập?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmationResult == DialogResult.Yes)
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@IdHoaDonNhapKho", cbo_IdHoaDon.SelectedValue),
                    new SqlParameter("@IdSanPham", cbo_TenSanPham.SelectedValue),
                };
                bool success = config.ExecuteStoredProcedure("sp_Xoa1ChiTietHoaDonNhapKho", parameters);

                if (!success)
                {
                    MessageBox.Show("Xoá chi tiết hoá đơn nhập không thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadListHoaDonNhap();
                LoadListChiTietHoaDon(cbo_IdHoaDon.Text);
            }
        }

        private void btn_ResetChiTietHoaDon_Click(object sender, EventArgs e)
        {
            ResetChiTietHoaDonNhap();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmRPHDNK rptHDNK = new frmRPHDNK();
            rptHDNK.ShowDialog();
        }
    }
}
