using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using FashionShopApp.GUI;
using FashionShopApp.Model;
using System.Security.Cryptography;

namespace FashionShopApp
{
    public partial class frmMain : Form
    {
        SQLConfig config = new SQLConfig(NguoiDungHienTai.CurentUser.nguoiDung.TenTaiKhoan, NguoiDungHienTai.CurentUser.nguoiDung.MatKhau);
        static string sql;
        public frmMain()
        {
            InitializeComponent();

            lb_CurrentUserName.Text = TenNguoiDungHienTai();
        }

        private void sbtn_Dashboard_Click(object sender, EventArgs e)
        {
            if (toolStrip2 != null)
            {
                toolStrip2.Items.Clear();


                //Thống kê
                ToolStripButton sbtn_ThongKe = new ToolStripButton();
                sbtn_ThongKe.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sbtn_ThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
                if (global::FashionShopApp.Properties.Resources.statistics != null)
                {
                    sbtn_ThongKe.Image = global::FashionShopApp.Properties.Resources.statistics;
                }
                sbtn_ThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sbtn_ThongKe.ImageTransparentColor = System.Drawing.Color.Magenta;
                sbtn_ThongKe.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
                sbtn_ThongKe.Name = "sbtn_ThongKe";
                sbtn_ThongKe.Size = new System.Drawing.Size(116, 29);
                sbtn_ThongKe.Text = "Thống Kê";
                sbtn_ThongKe.Click += new System.EventHandler(sbtn_ThongKe_Click);
                toolStrip2.Items.Add(sbtn_ThongKe);
            }

        }

        private void sbtn_ThongKe_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmThongKe());
        }

        private void sbtn_SanPham_Click(object sender, EventArgs e)
        {
            if (toolStrip2 != null)
            {
                toolStrip2.Items.Clear();


                //Quản lý sản phẩm
                ToolStripButton sbtn_QLSanPham = new ToolStripButton();
                sbtn_QLSanPham.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sbtn_QLSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
                if (global::FashionShopApp.Properties.Resources.product != null)
                    sbtn_QLSanPham.Image = global::FashionShopApp.Properties.Resources.product;
                sbtn_QLSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sbtn_QLSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
                sbtn_QLSanPham.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
                sbtn_QLSanPham.Name = "sbtn_QLSanPham";
                sbtn_QLSanPham.Size = new System.Drawing.Size(227, 35);
                sbtn_QLSanPham.Text = "Quản Lý Sản Phẩm";
                sbtn_QLSanPham.Click += new System.EventHandler(sbtn_QLSanPham_Click);
                toolStrip2.Items.Add(sbtn_QLSanPham);


                //Quản lý loại sản phẩm
                ToolStripButton sbtn_QLLoaiSanPham = new ToolStripButton();
                sbtn_QLLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sbtn_QLLoaiSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
                if (global::FashionShopApp.Properties.Resources.product_type != null)
                    sbtn_QLLoaiSanPham.Image = FashionShopApp.Properties.Resources.product_type;
                sbtn_QLLoaiSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sbtn_QLLoaiSanPham.ImageTransparentColor = System.Drawing.Color.Magenta;
                sbtn_QLLoaiSanPham.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
                sbtn_QLLoaiSanPham.Name = "sbtn_QLLoaiSanPham";
                sbtn_QLLoaiSanPham.Size = new System.Drawing.Size(275, 35);
                sbtn_QLLoaiSanPham.Text = "Quản Lý Loại Sản Phẩm";
                sbtn_QLLoaiSanPham.Click += new System.EventHandler(sbtn_QLLoaiSanPham_Click);
                toolStrip2.Items.Add(sbtn_QLLoaiSanPham);

            }
        }
        private void sbtn_QLSanPham_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmSanPham());
        }
        private void sbtn_QLLoaiSanPham_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmLoaiSanPham());
        }

        private void sbtn_KhachHang_Click(object sender, EventArgs e)
        {
            if (toolStrip2 != null)
            {
                toolStrip2.Items.Clear();


                //Quản lý thông tin khách hàng
                ToolStripButton sbtn_QLKhachHang = new ToolStripButton();
                sbtn_QLKhachHang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sbtn_QLKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
                if (global::FashionShopApp.Properties.Resources.customer != null)
                    sbtn_QLKhachHang.Image = global::FashionShopApp.Properties.Resources.customer;
                sbtn_QLKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sbtn_QLKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
                sbtn_QLKhachHang.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
                sbtn_QLKhachHang.Name = "sbtn_QLKhachHang";
                sbtn_QLKhachHang.Size = new System.Drawing.Size(227, 35);
                sbtn_QLKhachHang.Text = "Quản Lý Khách Hàng";
                sbtn_QLKhachHang.Click += new System.EventHandler(sbtn_QLKhachHang_Click);
                toolStrip2.Items.Add(sbtn_QLKhachHang);

                //Quản lý thông tin tài khoản khách hàng
                ToolStripButton sbtn_QLTaiKhoanKhachHang = new ToolStripButton();
                sbtn_QLTaiKhoanKhachHang.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sbtn_QLTaiKhoanKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
                if (global::FashionShopApp.Properties.Resources.customer != null)
                    sbtn_QLTaiKhoanKhachHang.Image = global::FashionShopApp.Properties.Resources.profile;
                sbtn_QLTaiKhoanKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sbtn_QLTaiKhoanKhachHang.ImageTransparentColor = System.Drawing.Color.Magenta;
                sbtn_QLTaiKhoanKhachHang.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
                sbtn_QLTaiKhoanKhachHang.Name = "sbtn_QLTaiKhoanKhachHang";
                sbtn_QLTaiKhoanKhachHang.Size = new System.Drawing.Size(227, 35);
                sbtn_QLTaiKhoanKhachHang.Text = "Quản Lý Tài Khoản Khách Hàng";
                sbtn_QLTaiKhoanKhachHang.Click += new System.EventHandler(sbtn_QLTaiKhoanKhachHang_Click);
                toolStrip2.Items.Add(sbtn_QLTaiKhoanKhachHang);

            }
        }
        private void sbtn_QLKhachHang_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmKhachHang());
        }
        private void sbtn_QLTaiKhoanKhachHang_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmTK_KhachHang());
        }
        private void sbtn_HoaDon_Click(object sender, EventArgs e)
        {
            if (toolStrip2 != null)
            {
                toolStrip2.Items.Clear();


                //Quản lý hóa đơn
                ToolStripButton sbtn_QLHoaDon = new ToolStripButton();
                sbtn_QLHoaDon.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sbtn_QLHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
                if (global::FashionShopApp.Properties.Resources.bill != null)
                    sbtn_QLHoaDon.Image = global::FashionShopApp.Properties.Resources.bill;
                sbtn_QLHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sbtn_QLHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
                sbtn_QLHoaDon.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
                sbtn_QLHoaDon.Name = "sbtn_QLKhachHang";
                sbtn_QLHoaDon.Size = new System.Drawing.Size(227, 35);
                sbtn_QLHoaDon.Text = "Quản Lý Hóa Đơn";
                sbtn_QLHoaDon.Click += new System.EventHandler(sbtn_QLHoaDon_Click);
                toolStrip2.Items.Add(sbtn_QLHoaDon);

                //Thanh Toán Hóa Đơn
                ToolStripButton sbtn_ThanhToanHoaDon = new ToolStripButton();
                sbtn_ThanhToanHoaDon.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sbtn_ThanhToanHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
                if (global::FashionShopApp.Properties.Resources.payment_method != null)
                    sbtn_ThanhToanHoaDon.Image = global::FashionShopApp.Properties.Resources.payment_method;
                sbtn_ThanhToanHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sbtn_ThanhToanHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
                sbtn_ThanhToanHoaDon.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
                sbtn_ThanhToanHoaDon.Name = "sbtn_ThanhToanHoaDon";
                sbtn_ThanhToanHoaDon.Size = new System.Drawing.Size(227, 35);
                sbtn_ThanhToanHoaDon.Text = "Thanh Toán Hóa Đơn";
                sbtn_ThanhToanHoaDon.Click += new System.EventHandler(sbtn_ThanhToanHoaDon_Click);
                toolStrip2.Items.Add(sbtn_ThanhToanHoaDon);


            }
        }
        private void sbtn_QLHoaDon_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmHoaDon());
        }
        private void sbtn_ThanhToanHoaDon_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmThanhToan());
        }
        private void sbtn_NhanVien_Click(object sender, EventArgs e)
        {
            if (toolStrip2 != null)
            {
                toolStrip2.Items.Clear();


                //Quản lý thông tin nhân viên
                ToolStripButton sbtn_QLNhanVien = new ToolStripButton();
                sbtn_QLNhanVien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sbtn_QLNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
                if (global::FashionShopApp.Properties.Resources.staff != null)
                    sbtn_QLNhanVien.Image = global::FashionShopApp.Properties.Resources.staff;
                sbtn_QLNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sbtn_QLNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
                sbtn_QLNhanVien.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
                sbtn_QLNhanVien.Name = "sbtn_QLNhanVien";
                sbtn_QLNhanVien.Size = new System.Drawing.Size(227, 35);
                sbtn_QLNhanVien.Text = "Quản Lý Nhân Viên";
                sbtn_QLNhanVien.Click += new System.EventHandler(sbtn_QLNhanVien_Click);
                toolStrip2.Items.Add(sbtn_QLNhanVien);


                //Quản lý thông tin tài khoản nhân viên
                ToolStripButton sbtn_QLTaiKhoanNhanVien = new ToolStripButton();
                sbtn_QLTaiKhoanNhanVien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sbtn_QLTaiKhoanNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
                if (global::FashionShopApp.Properties.Resources.staff != null)
                    sbtn_QLTaiKhoanNhanVien.Image = global::FashionShopApp.Properties.Resources.staff;
                sbtn_QLTaiKhoanNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sbtn_QLTaiKhoanNhanVien.ImageTransparentColor = System.Drawing.Color.Magenta;
                sbtn_QLTaiKhoanNhanVien.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
                sbtn_QLTaiKhoanNhanVien.Name = "sbtn_QLTaiKhoanNhanVien";
                sbtn_QLTaiKhoanNhanVien.Size = new System.Drawing.Size(227, 35);
                sbtn_QLTaiKhoanNhanVien.Text = "Quản Lý Tài Khoản Nhân Viên";
                sbtn_QLTaiKhoanNhanVien.Click += new System.EventHandler(sbtn_QLTaiKhoanNhanVien_Click);
                toolStrip2.Items.Add(sbtn_QLTaiKhoanNhanVien);
            }
        }
        private void sbtn_QLNhanVien_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmQLNhanVien());
        }
        private void sbtn_QLTaiKhoanNhanVien_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmQLTaiKhoanNV());
        }
        private void sbtn_PhanHoi_Click(object sender, EventArgs e)
        {
            if (toolStrip2 != null)
            {
                toolStrip2.Items.Clear();


                //Quản lý phản hồi của khách hàng
                ToolStripButton sbtn_PhanHoiCuaKH = new ToolStripButton();
                sbtn_PhanHoiCuaKH.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sbtn_PhanHoiCuaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
                if (global::FashionShopApp.Properties.Resources.feedback != null)
                    sbtn_PhanHoiCuaKH.Image = global::FashionShopApp.Properties.Resources.feedback;
                sbtn_PhanHoiCuaKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sbtn_PhanHoiCuaKH.ImageTransparentColor = System.Drawing.Color.Magenta;
                sbtn_PhanHoiCuaKH.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
                sbtn_PhanHoiCuaKH.Name = "sbtn_PhanHoiCuaKH";
                sbtn_PhanHoiCuaKH.Size = new System.Drawing.Size(227, 35);
                sbtn_PhanHoiCuaKH.Text = "Phản Hồi Của Khách Hàng";
                sbtn_PhanHoiCuaKH.Click += new System.EventHandler(sbtn_PhanHoiCuaKH_Click);
                toolStrip2.Items.Add(sbtn_PhanHoiCuaKH);



            }
        }

        private void sbtn_PhanHoiCuaKH_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmPhanHoi());
        }
        private void sbtn_Kho_Click(object sender, EventArgs e)
        {
            if (toolStrip2 != null)
            {
                toolStrip2.Items.Clear();


                //Quản lý hoá đơn nhập kho
                ToolStripButton sbtn_QLHdNhapKho = new ToolStripButton();
                sbtn_QLHdNhapKho.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sbtn_QLHdNhapKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
                if (global::FashionShopApp.Properties.Resources.warehouse != null)
                    sbtn_QLHdNhapKho.Image = global::FashionShopApp.Properties.Resources.warehouse;
                sbtn_QLHdNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sbtn_QLHdNhapKho.ImageTransparentColor = System.Drawing.Color.Magenta;
                sbtn_QLHdNhapKho.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
                sbtn_QLHdNhapKho.Name = "sbtn_QLHdNhapKho";
                sbtn_QLHdNhapKho.Size = new System.Drawing.Size(227, 35);
                sbtn_QLHdNhapKho.Text = "Quản Lý Hoá Đơn Nhập Kho";
                sbtn_QLHdNhapKho.Click += new System.EventHandler(sbtn_QLHdNhapKho_Click);
                toolStrip2.Items.Add(sbtn_QLHdNhapKho);


                //Quản lý kho
                ToolStripButton sbtn_QLKho = new ToolStripButton();
                sbtn_QLKho.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                sbtn_QLKho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
                if (global::FashionShopApp.Properties.Resources.warehouse != null)
                    sbtn_QLKho.Image = global::FashionShopApp.Properties.Resources.icons8_manage_64;
                sbtn_QLKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                sbtn_QLKho.ImageTransparentColor = System.Drawing.Color.Magenta;
                sbtn_QLKho.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
                sbtn_QLKho.Name = "sbtn_QLKho";
                sbtn_QLKho.Size = new System.Drawing.Size(227, 35);
                sbtn_QLKho.Text = "Quản Lý Kho";
                sbtn_QLKho.Click += new System.EventHandler(sbtn_QLKho_Click);
                toolStrip2.Items.Add(sbtn_QLKho);



            }
        }

        private void sbtn_QLHdNhapKho_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmNhapKho());
        }
        private void sbtn_QLKho_Click(object sender, EventArgs e)
        {
            closeForm();
            showFrm(new frmKho());
        }
        public void closeForm()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }

        }
        public void showFrm(Form frm)
        {
            this.IsMdiContainer = true;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Show();
        }
        public string TenNguoiDungHienTai()
        {
            string temp = null;
            sql = "SELECT TenNhanVien FROM NhanVien WHERE IdNguoiDung = " + NguoiDungHienTai.CurentUser.nguoiDung.IdNguoiDung;
            DataTable dt = config.ExecuteSelectQuery(sql);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    temp = dr[0].ToString();
                }
            }
            return temp;

        }
        private void sbtn_DangXuat_Click(object sender, EventArgs e)
        {
            NguoiDungHienTai.CurentUser.nguoiDung = new NguoiDung();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
        }

    }
}
