using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FashionShopApp.Model;

namespace FashionShopApp.GUI
{
    public partial class frmThanhToan : Form
    {
        SQLConfig config = new SQLConfig();
        string sql;
        private Timer timer = new Timer();
        public frmThanhToan()
        {
            InitializeComponent();
            LoadCboTenSanPham();
            LoadCboChiNhanh();

            dtpNgayBan.Format = DateTimePickerFormat.Custom;
            dtpNgayBan.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            // Đặt Interval của Timer thành 1000 milliseconds (1 giây)
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            dtpNgayBan.Value = DateTime.Now;
        }
        public void LoadCboTenSanPham()
        {
            sql = "SELECT TenSanPham FROM SanPham";
            DataTable dataTable = config.ExecuteSelectQuery(sql);

            List<string> listIdSanPham = new List<string>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    listIdSanPham.Add(row[0].ToString());
                }
            }
            else
                listIdSanPham.Add("Chưa có sản phẩm");
            cbo_TenSanPham.DataSource = listIdSanPham;
            cbo_TenSanPham.SelectedIndex = -1;
        }
        public void LoadCboChiNhanh()
        {
            sql = "SELECT TenChiNhanh FROM ChiNhanh";
            DataTable dataTable = config.ExecuteSelectQuery(sql);

            List<string> listChiNhanh = new List<string>();
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    listChiNhanh.Add(row[0].ToString());
                }
            }
            else
                listChiNhanh.Add("Chưa có chi nhánh");
            cbo_ChiNhanh.DataSource = listChiNhanh;
            cbo_ChiNhanh.SelectedIndex = -1;
        }
        public void FormThanhToan_Load(object sender, EventArgs e)
        {
            txt_IdSanPham.Text = null;
            cbo_TenSanPham.SelectedIndex = -1;
            nmud_SoLuong.Value = 1;
            txt_DonGia.Text = null;
            nmud_GiamGia.Value = 0;
            txt_ThanhTien.Text = null;
            ptb_SanPham.Image = null;
            try
            {
                sql = "SELECT * FROM NhanVien WHERE IdNguoiDung = '" + NguoiDungHienTai.CurentUser.nguoiDung.IdNguoiDung + "'";
                DataTable dataTable = config.ExecuteSelectQuery(sql);

                if (dataTable.Rows.Count > 0)
                {

                    foreach (DataRow row in dataTable.Rows)
                    {
                        txt_IdNhanVien.Text = row["IdNhanVien"].ToString();
                        txt_TenNhanVien.Text = row["TenNhanVien"].ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
        public void txt_SoDienThoai_Leave(object sender, EventArgs e)
        {
            string soDienThoai = txt_SoDienThoai.Text;

            try
            {
                if (txt_SoDienThoai.Text != null)
                {
                    sql = "SELECT IdKhachHang, TenKhachHang, DiaChi FROM KhachHang WHERE SoDienThoai = '" + soDienThoai + "'";
                    DataTable dataTable = config.ExecuteSelectQuery(sql);

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            txt_IdKhachHang.Text = row["IdKhachHang"].ToString();
                            txt_TenKhachHang.Text = row["TenKhachHang"].ToString();
                            txt_DiaChi.Text = row["DiaChi"].ToString();
                        }
                    }
                    else
                    {
                        // Nếu không tìm thấy thông tin, xóa các TextBox
                        txt_TenKhachHang.Clear();
                        txt_DiaChi.Clear();
                        txt_SoDienThoai.Clear();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
        private void txt_SoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (txt_SoDienThoai.Text.Length == 0)
            {
                txt_IdKhachHang.Text = string.Empty;
                txt_TenKhachHang.Text = string.Empty;
                txt_DiaChi.Text = string.Empty;
            }
        }
        public void cbo_TenSanPham_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = sender as ComboBox;
                if (cmb.SelectedItem != null)
                {
                    sql = "SELECT IdLoaiSP, AnhSP, GiaBan, GiamGia FROM SanPham WHERE TenSanPham = N'" + cbo_TenSanPham.Text + "'";
                    DataTable dataTable = config.ExecuteSelectQuery(sql);

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            txt_IdSanPham.Text = row[0].ToString();
                            LoadImageIntoPictureBox(row[1].ToString(), ptb_SanPham);
                            int giaGoc = int.Parse(row[2].ToString());
                            txt_DonGia.Text = giaGoc.ToString();
                            int giamGia = int.Parse(row[3].ToString());
                            nmud_GiamGia.Value = giamGia;
                            txt_ThanhTien.Text = (giaGoc * (100 - giamGia) / 100).ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            if (cbo_TenSanPham.Text != "")
            {
                string idSanPham = txt_IdSanPham.Text;
                string tenSanPham = cbo_TenSanPham.Text;
                string donGia = txt_DonGia.Text;
                int soLuong = (int)nmud_SoLuong.Value;
                int giamGia = (int)nmud_GiamGia.Value;
                string thanhTien = txt_ThanhTien.Text;

                bool daTonTai = false;

                foreach (ListViewItem item in lsvSanPham.Items)
                {
                    if (item.SubItems[0].Text == idSanPham)
                    {
                        // Tăng số lượng lên 1
                        item.SubItems[3].Text = (int.Parse(item.SubItems[3].Text) + soLuong).ToString();

                        item.SubItems[5].Text = (int.Parse(item.SubItems[3].Text) * (int.Parse(item.SubItems[2].Text) - int.Parse(item.SubItems[2].Text) * int.Parse(item.SubItems[4].Text) / 100)).ToString();
                        daTonTai = true;
                        break;
                    }
                }

                if (!daTonTai)
                {
                    ListViewItem item = lsvSanPham.Items.Add(idSanPham);
                    item.SubItems.Add(tenSanPham);
                    item.SubItems.Add(donGia);
                    item.SubItems.Add(soLuong.ToString());
                    item.SubItems.Add(giamGia.ToString());
                    item.SubItems.Add(thanhTien);
                }
                int tongTien = 0;
                foreach (ListViewItem item in lsvSanPham.Items)
                {
                    tongTien += int.Parse(item.SubItems[5].Text);
                }
                txt_TongTien.Text = tongTien.ToString("#,##0đ");
            }
        }
        private void txt_TienKhachDua_Leave(object sender, EventArgs e)
        {
            if (txt_TongTien.Text != "" && txt_TienKhachDua.Text != "")
            {
                string tongTienStr = txt_TongTien.Text.Replace("đ", "").Replace(".", "");
                int tongTienInt = int.Parse(tongTienStr);
                txt_TienThoi.Text = (int.Parse(txt_TienKhachDua.Text) - tongTienInt).ToString("#,##0đ");
            }
        }
        private void btnResetHoaDon_Click(object sender, EventArgs e)
        {
            ResetHoaDon();
        }
        private void ResetHoaDon()
        {
            txt_SoDienThoai.Text = string.Empty;
            cbo_TenSanPham.SelectedIndex = -1;
            txt_IdSanPham.Text = string.Empty;
            txt_DonGia.Text = string.Empty;
            nmud_SoLuong.Value = 1;
            nmud_GiamGia.Value = 0;
            txt_ThanhTien.Text = string.Empty;
            lsvSanPham.Items.Clear();
            txt_TongTien.Text = string.Empty;
            txt_TienKhachDua.Text = string.Empty;
            txt_TienThoi.Text = string.Empty;

        }
        private void nud_SoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (txt_DonGia.Text != "")
            {
                int giaDaGiam = int.Parse(txt_DonGia.Text) - int.Parse(txt_DonGia.Text) * int.Parse(nmud_GiamGia.Text) / 100;
                txt_ThanhTien.Text = (nmud_SoLuong.Value * giaDaGiam).ToString();
            }
        }
        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo_ChiNhanh.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn chi nhánh!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cbo_PtThanhToan.SelectedIndex == -1)
                    {
                        MessageBox.Show("Vui lòng chọn phương thức thanh toán!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string tongTienStr = txt_TongTien.Text.Replace("đ", "").Replace(".", "");
                        if (lsvSanPham.Items.Count > 0)
                        {
                            if (!string.IsNullOrEmpty(txt_SoDienThoai.Text))
                            {
                                sql = String.Format("INSERT INTO HoaDon VALUES ({0},{1},'{2}',N'{3}',GETDATE()) SELECT SCOPE_IDENTITY() AS IdHoaDon;", txt_IdNhanVien.Text, GetIdChiNhanh(cbo_ChiNhanh.Text), txt_SoDienThoai.Text, cbo_PtThanhToan.Text);
                            }
                            else
                                sql = String.Format("INSERT INTO HoaDon VALUES ({0},{1},null,N'{2}',GETDATE()) SELECT SCOPE_IDENTITY() AS IdHoaDon;", txt_IdNhanVien.Text, GetIdChiNhanh(cbo_ChiNhanh.Text), cbo_PtThanhToan.Text);
                            object result = config.ExecuteScalar(sql);
                            int id = int.Parse(result.ToString());
                            if (id > 0)
                            {
                                foreach (ListViewItem item in lsvSanPham.Items)
                                {
                                    string sql2 = "INSERT INTO ChiTietHoaDon VALUES ('" + id + "','" + item.SubItems[0].Text + "'," + item.SubItems[3].Text + "," + item.SubItems[5].Text + ");";
                                    config.ExecuteNonQuery(sql2);
                                }
                            }

                        }
                        MessageBox.Show("Đã mua hàng thành công", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        ResetHoaDon();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
        private int GetIdChiNhanh(string tenChiNhanh)
        {
            int id = -1;
            try
            {
                sql = String.Format("SELECT IdChiNhanh FROM ChiNhanh WHERE TenChiNhanh = N'{0}'", cbo_ChiNhanh.Text);
                DataTable dataTable = config.ExecuteSelectQuery(sql);
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        id = int.Parse(row[0].ToString());
                    }
                }
                return id;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Lỗi SQL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            return id;
        }
        private void LoadImageIntoPictureBox(string imageName, PictureBox ptb)
        {
            try
            {
                if(!string.IsNullOrEmpty(imageName))
                {
                    string folderPath = "Images";
                    string imagePath = System.IO.Path.Combine(folderPath, imageName);
                    if (System.IO.File.Exists(imagePath))
                    {
                        Image image = Image.FromFile(imagePath);
                        ptb.Image = image;

                        ptb.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        MessageBox.Show("Tệp ảnh không tồn tại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
    }
}
