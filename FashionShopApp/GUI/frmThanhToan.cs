using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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
            sql = "SELECT IdSanPham,TenSanPham FROM SanPham ORDER BY IdSanPham ASC";
            DataTable dt = config.ExecuteSelectQuery(sql);
            List<object> items = new List<object>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    items.Add(new { Text = dr[1].ToString(), Value = dr[0] });
                }

                cbo_TenSanPham.DataSource = items;
                cbo_TenSanPham.DisplayMember = "Text";
                cbo_TenSanPham.ValueMember = "Value";
            }
            else
            {
                items.Add(new { Text = "Chưa có sản phẩm", Value = -1 });
            }

            cbo_TenSanPham.SelectedIndex = -1;
        }
        public void LoadCboChiNhanh()
        {
            sql = "SELECT IdChiNhanh,TenChiNhanh FROM ChiNhanh ORDER BY IdChiNhanh ASC";
            DataTable dt = config.ExecuteSelectQuery(sql);
            List<object> items = new List<object>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    items.Add(new { Text = dr[1].ToString(), Value = dr[0] });
                }

                cbo_ChiNhanh.DataSource = items;
                cbo_ChiNhanh.DisplayMember = "Text";
                cbo_ChiNhanh.ValueMember = "Value";
            }
            else
            {
                items.Add(new { Text = "Chưa có chi nhánh", Value = -1 });
            }

            cbo_ChiNhanh.SelectedIndex = -1;
        }
        public void FormThanhToan_Load(object sender, EventArgs e)
        {
            LoadCboTenSanPham();
            LoadCboChiNhanh();
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
                    sql = string.Format("SELECT IdLoaiSP, AnhSP, GiaBan, GiamGia FROM SanPham WHERE IdSanPham = {0}", cbo_TenSanPham.SelectedValue);
                    DataTable dataTable = config.ExecuteSelectQuery(sql);

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            txt_IdSanPham.Text = cbo_TenSanPham.SelectedValue.ToString();
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
            if (cbo_TenSanPham.SelectedIndex != -1)
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
                                sql = String.Format("INSERT INTO HoaDon VALUES ({0},{1},'{2}',N'{3}',GETDATE()) SELECT SCOPE_IDENTITY() AS IdHoaDon;", txt_IdNhanVien.Text, cbo_ChiNhanh.SelectedValue, txt_SoDienThoai.Text, cbo_PtThanhToan.Text);
                            }
                            else
                                sql = String.Format("INSERT INTO HoaDon VALUES ({0},{1},null,N'{2}',GETDATE()) SELECT SCOPE_IDENTITY() AS IdHoaDon;", txt_IdNhanVien.Text, cbo_ChiNhanh.SelectedValue, cbo_PtThanhToan.Text);
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
                        InHoaDon();
                        MessageBox.Show("Đã xuất hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void LoadImageIntoPictureBox(string imageName, PictureBox ptb)
        {
            try
            {
                if (!string.IsNullOrEmpty(imageName))
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
        private string GetDiaChiChiNhanh(int idChiNhanh)
        {
            string tenChiNhanh = string.Empty;
            sql = string.Format("SELECT DiaChi FROM ChiNhanh WHERE IdChiNhanh = {0}", idChiNhanh);
            DataTable dataTable = config.ExecuteSelectQuery(sql);
            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    tenChiNhanh = row[0].ToString();
                }
            }
            return tenChiNhanh;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Brush brush = Brushes.Black;

            //logo
            Image image = global::FashionShopApp.Properties.Resources.logo_shop;
            e.Graphics.DrawImage(image, new Point((e.PageBounds.Width - image.Width) / 2, 15));
            //Header
            string txtHeader = "HÓA ĐƠN THANH TOÁN";
            Font frontHeader = new Font("Arial", 24, FontStyle.Bold);
            e.Graphics.DrawString(txtHeader, frontHeader, brush, new Point(centerRow(e, txtHeader, frontHeader), 110));

            //Chi Nhánh
            string txtChiNhanh = cbo_ChiNhanh.Text;
            Font frontChiNhanh = new Font("Arial", 18, FontStyle.Bold);
            e.Graphics.DrawString(txtChiNhanh, frontChiNhanh, brush, new Point(centerRow(e, txtChiNhanh, frontChiNhanh), 155));

            //Tên Chi Nhánh
            string txtTenChiNhanh = GetDiaChiChiNhanh(int.Parse(cbo_ChiNhanh.SelectedValue.ToString()));

            Font frontTenChiNhanh = new Font("Arial", 14, FontStyle.Regular);
            e.Graphics.DrawString(txtTenChiNhanh, frontTenChiNhanh, brush, new Point(centerRow(e, txtTenChiNhanh, frontTenChiNhanh), 190));

            //Số điện thoại
            string txtSDT = "Hotline: 111 222 3333";
            Font frontSDT = new Font("Arial", 14, FontStyle.Bold);
            e.Graphics.DrawString(txtSDT, frontSDT, brush, new Point(centerRow(e, txtSDT, frontSDT), 220));

            //Nhân viên     
            string txtNhanVien = "Nhân viên: " + txt_TenNhanVien.Text;
            Font frontNhanVien = new Font("Arial", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtNhanVien, frontNhanVien, brush, new Point(10, 280));

            //Thời gian xuất hóa đơn
            DateTime gioXuatHD = dtpNgayBan.Value;
            string txtGioXuatHD = "Thời gian xuất hóa đơn: " + gioXuatHD.ToString("HH:mm:ss dd/MM/yyyy");
            Font frontGioXuatHD = new Font("Arial", 12, FontStyle.Regular);
            e.Graphics.DrawString(txtGioXuatHD, frontGioXuatHD, brush, new Point(10, 300));

            //Chuỗi ------------
            string breakString = string.Empty;
            for (int i = 10; i <= 150; i++)
            {
                breakString += "-";
            }
            Font frontBreakString = new Font("Arial", 12, FontStyle.Bold);
            e.Graphics.DrawString(breakString, frontBreakString, brush, new Point(10, 330));

            int y = 350;

            foreach (ListViewItem item in lsvSanPham.Items)
            {

                //Tên sản phẩm
                string txtTenSP = item.SubItems[1].Text;
                Font frontTenSP = new Font("Arial", 12, FontStyle.Regular);
                e.Graphics.DrawString(txtTenSP, frontTenSP, brush, new Point(10, y));

                //Giảm giá
                int giaGiam = int.Parse(item.SubItems[2].Text) - (int.Parse(item.SubItems[2].Text) * int.Parse(item.SubItems[4].Text) / 100);
                string txtGiaGiam = string.Format("{0:n0}", giaGiam);
                Font frontGiaGiam = new Font("Arial", 12, FontStyle.Regular);
                e.Graphics.DrawString(txtGiaGiam, frontGiaGiam, brush, new Point(10, y + 20));
                int giaGiamSize = (int)((SizeF)e.Graphics.MeasureString(txtGiaGiam, frontGiaGiam)).Width;

                //Giá
                string txtGia = string.Format("{0:n0}", int.Parse(item.SubItems[2].Text));
                Font frontGia = new Font("Arial", 12, FontStyle.Strikeout);
                e.Graphics.DrawString(txtGia, frontGia, brush, new Point(giaGiamSize + 20, y + 20));
                int giaSize = (int)((SizeF)e.Graphics.MeasureString(txtGia, frontGia)).Width;

                //Số lượng
                string txtSoLuong = item.SubItems[3].Text;
                Font frontSoLuong = new Font("Arial", 12, FontStyle.Regular);
                e.Graphics.DrawString(txtSoLuong, frontSoLuong, brush, new Point(450, y + 20));

                //ThanhTien
                string txtThanhTien = string.Format("{0:n0}", int.Parse(item.SubItems[5].Text));
                Font frontThanhTien = new Font("Arial", 12, FontStyle.Regular);
                int thanhTienSize = (int)((SizeF)e.Graphics.MeasureString(txtThanhTien, frontThanhTien)).Width;
                e.Graphics.DrawString(txtThanhTien, frontThanhTien, brush, new Point(e.PageBounds.Width - thanhTienSize - 15, y + 20));

                y += 40;
            }

            //Chuỗi ------------
            string breakString2 = string.Empty;
            for (int i = 10; i <= 150; i++)
            {
                breakString2 += "-";
            }
            Font frontBreakString2 = new Font("Arial", 12, FontStyle.Bold);
            e.Graphics.DrawString(breakString, frontBreakString, brush, new Point(10, y));



            string txtTongCong = "TỔNG CỘNG";
            Font frontTongCong = new Font("Arial", 18, FontStyle.Bold);
            e.Graphics.DrawString(txtTongCong, frontTongCong, brush, new Point(10, y + 30));



            //Số lượng
            string txtDVT = "VNĐ";
            Font frontDVT = new Font("Arial", 18, FontStyle.Bold);
            e.Graphics.DrawString(txtDVT, frontDVT, brush, new Point(450, y + 30));

            //ThanhTien
            string txtTongThanhTien = txt_TongTien.Text;
            Font frontTongThanhTien = new Font("Arial", 18, FontStyle.Bold);
            int tongThanhTienSize = (int)((SizeF)e.Graphics.MeasureString(txtTongThanhTien, frontTongThanhTien)).Width;
            e.Graphics.DrawString(txtTongThanhTien, frontTongThanhTien, brush, new Point(e.PageBounds.Width - tongThanhTienSize - 15, y + 30));
        }
        private int centerRow(System.Drawing.Printing.PrintPageEventArgs e, string text, Font font)
        {
            int pageWidth = e.PageBounds.Width;
            SizeF textSize = e.Graphics.MeasureString(text, font);
            int x = (int)((pageWidth - textSize.Width) / 2);
            return x;
        }
        private void InHoaDon()
        {
            try
            {
                string downloadFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
                string filePath = Path.Combine(downloadFolderPath, "HoaDon.pdf");

                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printDocument.PrinterSettings.PrintToFile = true;
                printDocument.PrinterSettings.PrintFileName = filePath;
                printDocument.Print();

                if (File.Exists(filePath))
                {
                    using (FileStream fs = new FileStream(filePath, FileMode.Create))
                    {
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Lỗi: {ex.Message}");
            }

        }
    }
}
