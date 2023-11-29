namespace FashionShopApp.GUI
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.lsv_DanhSachHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_ResetHoaDon = new System.Windows.Forms.Button();
            this.btn_XoaHoaDon = new System.Windows.Forms.Button();
            this.btn_CapNhatHoaDon = new System.Windows.Forms.Button();
            this.btn_ThemHoaDon = new System.Windows.Forms.Button();
            this.cbo_ChiNhanh = new System.Windows.Forms.ComboBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_IdHoaDon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_NgayXuatHoaDon = new System.Windows.Forms.DateTimePicker();
            this.cbo_PtThanhToan = new System.Windows.Forms.ComboBox();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_NhanVien = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lsv_ChiTietHoaDon = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ResetChiTietHoaDon = new System.Windows.Forms.Button();
            this.btn_XoaChiTietHoaDon = new System.Windows.Forms.Button();
            this.btn_ThemChiTietHoaDon = new System.Windows.Forms.Button();
            this.btn_CapNhatChiTietHoaDon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_IdHoaDon = new System.Windows.Forms.ComboBox();
            this.nmud_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_TenSanPham = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmud_SoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lsv_DanhSachHoaDon
            // 
            this.lsv_DanhSachHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lsv_DanhSachHoaDon.FullRowSelect = true;
            this.lsv_DanhSachHoaDon.HideSelection = false;
            this.lsv_DanhSachHoaDon.Location = new System.Drawing.Point(34, 39);
            this.lsv_DanhSachHoaDon.MultiSelect = false;
            this.lsv_DanhSachHoaDon.Name = "lsv_DanhSachHoaDon";
            this.lsv_DanhSachHoaDon.Size = new System.Drawing.Size(893, 236);
            this.lsv_DanhSachHoaDon.TabIndex = 2;
            this.lsv_DanhSachHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachHoaDon.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachHoaDon.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachHoaDon_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hóa đơn";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Nhân viên";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Chi nhánh";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số điện thoại";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phương thức thanh toán";
            this.columnHeader5.Width = 161;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ngày xuất hóa đơn";
            this.columnHeader6.Width = 109;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tổng tiền";
            this.columnHeader7.Width = 102;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsv_DanhSachHoaDon);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 346);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(963, 291);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hóa đơn";
            // 
            // btn_ResetHoaDon
            // 
            this.btn_ResetHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ResetHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_ResetHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ResetHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_ResetHoaDon.Image")));
            this.btn_ResetHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ResetHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ResetHoaDon.Location = new System.Drawing.Point(88, 208);
            this.btn_ResetHoaDon.Name = "btn_ResetHoaDon";
            this.btn_ResetHoaDon.Size = new System.Drawing.Size(121, 37);
            this.btn_ResetHoaDon.TabIndex = 36;
            this.btn_ResetHoaDon.Text = "Reset";
            this.btn_ResetHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ResetHoaDon.UseVisualStyleBackColor = false;
            this.btn_ResetHoaDon.Click += new System.EventHandler(this.btn_ResetHoaDon_Click);
            // 
            // btn_XoaHoaDon
            // 
            this.btn_XoaHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_XoaHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_XoaHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHoaDon.Image = global::FashionShopApp.Properties.Resources.delete;
            this.btn_XoaHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_XoaHoaDon.Location = new System.Drawing.Point(695, 208);
            this.btn_XoaHoaDon.Name = "btn_XoaHoaDon";
            this.btn_XoaHoaDon.Size = new System.Drawing.Size(110, 37);
            this.btn_XoaHoaDon.TabIndex = 35;
            this.btn_XoaHoaDon.Text = "Xóa";
            this.btn_XoaHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaHoaDon.UseVisualStyleBackColor = false;
            this.btn_XoaHoaDon.Click += new System.EventHandler(this.btn_XoaHoaDon_Click);
            // 
            // btn_CapNhatHoaDon
            // 
            this.btn_CapNhatHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CapNhatHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_CapNhatHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhatHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CapNhatHoaDon.Image = global::FashionShopApp.Properties.Resources.updated;
            this.btn_CapNhatHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhatHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_CapNhatHoaDon.Location = new System.Drawing.Point(477, 208);
            this.btn_CapNhatHoaDon.Name = "btn_CapNhatHoaDon";
            this.btn_CapNhatHoaDon.Size = new System.Drawing.Size(140, 37);
            this.btn_CapNhatHoaDon.TabIndex = 31;
            this.btn_CapNhatHoaDon.Text = "Cập nhật";
            this.btn_CapNhatHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CapNhatHoaDon.UseVisualStyleBackColor = false;
            this.btn_CapNhatHoaDon.Click += new System.EventHandler(this.btn_CapNhatHoaDon_Click);
            // 
            // btn_ThemHoaDon
            // 
            this.btn_ThemHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ThemHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_ThemHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHoaDon.Image = global::FashionShopApp.Properties.Resources.add;
            this.btn_ThemHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThemHoaDon.Location = new System.Drawing.Point(286, 208);
            this.btn_ThemHoaDon.Name = "btn_ThemHoaDon";
            this.btn_ThemHoaDon.Size = new System.Drawing.Size(113, 37);
            this.btn_ThemHoaDon.TabIndex = 33;
            this.btn_ThemHoaDon.Text = "Thêm";
            this.btn_ThemHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemHoaDon.UseVisualStyleBackColor = false;
            this.btn_ThemHoaDon.Click += new System.EventHandler(this.btn_ThemHoaDon_Click);
            // 
            // cbo_ChiNhanh
            // 
            this.cbo_ChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ChiNhanh.FormattingEnabled = true;
            this.cbo_ChiNhanh.Location = new System.Drawing.Point(784, 26);
            this.cbo_ChiNhanh.Name = "cbo_ChiNhanh";
            this.cbo_ChiNhanh.Size = new System.Drawing.Size(168, 37);
            this.cbo_ChiNhanh.TabIndex = 2;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(230, 82);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(202, 34);
            this.txt_SoDienThoai.TabIndex = 1;
            // 
            // txt_IdHoaDon
            // 
            this.txt_IdHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdHoaDon.Location = new System.Drawing.Point(158, 26);
            this.txt_IdHoaDon.Name = "txt_IdHoaDon";
            this.txt_IdHoaDon.ReadOnly = true;
            this.txt_IdHoaDon.Size = new System.Drawing.Size(133, 34);
            this.txt_IdHoaDon.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label6.Location = new System.Drawing.Point(658, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chi nhánh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label5.Location = new System.Drawing.Point(13, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(13, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã hóa đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_NgayXuatHoaDon);
            this.groupBox3.Controls.Add(this.cbo_PtThanhToan);
            this.groupBox3.Controls.Add(this.txt_TongTien);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.btn_ResetHoaDon);
            this.groupBox3.Controls.Add(this.btn_XoaHoaDon);
            this.groupBox3.Controls.Add(this.btn_CapNhatHoaDon);
            this.groupBox3.Controls.Add(this.btn_ThemHoaDon);
            this.groupBox3.Controls.Add(this.cbo_NhanVien);
            this.groupBox3.Controls.Add(this.cbo_ChiNhanh);
            this.groupBox3.Controls.Add(this.txt_SoDienThoai);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_IdHoaDon);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(963, 261);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hóa đơn";
            // 
            // dtp_NgayXuatHoaDon
            // 
            this.dtp_NgayXuatHoaDon.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtp_NgayXuatHoaDon.Enabled = false;
            this.dtp_NgayXuatHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_NgayXuatHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayXuatHoaDon.Location = new System.Drawing.Point(230, 146);
            this.dtp_NgayXuatHoaDon.Name = "dtp_NgayXuatHoaDon";
            this.dtp_NgayXuatHoaDon.Size = new System.Drawing.Size(202, 34);
            this.dtp_NgayXuatHoaDon.TabIndex = 40;
            // 
            // cbo_PtThanhToan
            // 
            this.cbo_PtThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_PtThanhToan.FormattingEnabled = true;
            this.cbo_PtThanhToan.Items.AddRange(new object[] {
            "Tiền mặt",
            "Trực tuyến"});
            this.cbo_PtThanhToan.Location = new System.Drawing.Point(739, 82);
            this.cbo_PtThanhToan.Name = "cbo_PtThanhToan";
            this.cbo_PtThanhToan.Size = new System.Drawing.Size(213, 37);
            this.cbo_PtThanhToan.TabIndex = 39;
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(739, 138);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(213, 34);
            this.txt_TongTien.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label10.Location = new System.Drawing.Point(456, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 29);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tổng tiền hóa đơn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label9.Location = new System.Drawing.Point(13, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 29);
            this.label9.TabIndex = 37;
            this.label9.Text = "Ngày xuất hóa đơn";
            // 
            // cbo_NhanVien
            // 
            this.cbo_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_NhanVien.FormattingEnabled = true;
            this.cbo_NhanVien.Location = new System.Drawing.Point(450, 26);
            this.cbo_NhanVien.Name = "cbo_NhanVien";
            this.cbo_NhanVien.Size = new System.Drawing.Size(180, 37);
            this.cbo_NhanVien.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label7.Location = new System.Drawing.Point(322, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label8.Location = new System.Drawing.Point(456, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(262, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phương thức thanh toán";
            // 
            // lsv_ChiTietHoaDon
            // 
            this.lsv_ChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lsv_ChiTietHoaDon.FullRowSelect = true;
            this.lsv_ChiTietHoaDon.HideSelection = false;
            this.lsv_ChiTietHoaDon.Location = new System.Drawing.Point(25, 39);
            this.lsv_ChiTietHoaDon.MultiSelect = false;
            this.lsv_ChiTietHoaDon.Name = "lsv_ChiTietHoaDon";
            this.lsv_ChiTietHoaDon.Size = new System.Drawing.Size(494, 236);
            this.lsv_ChiTietHoaDon.TabIndex = 1;
            this.lsv_ChiTietHoaDon.UseCompatibleStateImageBehavior = false;
            this.lsv_ChiTietHoaDon.View = System.Windows.Forms.View.Details;
            this.lsv_ChiTietHoaDon.SelectedIndexChanged += new System.EventHandler(this.lsv_ChiTietHoaDon_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã hóa đơn";
            this.columnHeader8.Width = 93;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Sản phẩm";
            this.columnHeader9.Width = 203;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Số lượng";
            this.columnHeader10.Width = 79;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Đơn giá";
            this.columnHeader11.Width = 94;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsv_ChiTietHoaDon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(992, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 291);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết hóa đơn";
            // 
            // btn_ResetChiTietHoaDon
            // 
            this.btn_ResetChiTietHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ResetChiTietHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_ResetChiTietHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ResetChiTietHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_ResetChiTietHoaDon.Image")));
            this.btn_ResetChiTietHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ResetChiTietHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ResetChiTietHoaDon.Location = new System.Drawing.Point(20, 208);
            this.btn_ResetChiTietHoaDon.Name = "btn_ResetChiTietHoaDon";
            this.btn_ResetChiTietHoaDon.Size = new System.Drawing.Size(94, 37);
            this.btn_ResetChiTietHoaDon.TabIndex = 36;
            this.btn_ResetChiTietHoaDon.Text = "Reset";
            this.btn_ResetChiTietHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ResetChiTietHoaDon.UseVisualStyleBackColor = false;
            this.btn_ResetChiTietHoaDon.Click += new System.EventHandler(this.btn_ResetChiTietHoaDon_Click);
            // 
            // btn_XoaChiTietHoaDon
            // 
            this.btn_XoaChiTietHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_XoaChiTietHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_XoaChiTietHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_XoaChiTietHoaDon.Image = global::FashionShopApp.Properties.Resources.delete;
            this.btn_XoaChiTietHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaChiTietHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_XoaChiTietHoaDon.Location = new System.Drawing.Point(420, 208);
            this.btn_XoaChiTietHoaDon.Name = "btn_XoaChiTietHoaDon";
            this.btn_XoaChiTietHoaDon.Size = new System.Drawing.Size(103, 37);
            this.btn_XoaChiTietHoaDon.TabIndex = 32;
            this.btn_XoaChiTietHoaDon.Text = "Xóa";
            this.btn_XoaChiTietHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaChiTietHoaDon.UseVisualStyleBackColor = false;
            this.btn_XoaChiTietHoaDon.Click += new System.EventHandler(this.btn_XoaChiTietHoaDon_Click);
            // 
            // btn_ThemChiTietHoaDon
            // 
            this.btn_ThemChiTietHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ThemChiTietHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_ThemChiTietHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ThemChiTietHoaDon.Image = global::FashionShopApp.Properties.Resources.add;
            this.btn_ThemChiTietHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemChiTietHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThemChiTietHoaDon.Location = new System.Drawing.Point(138, 208);
            this.btn_ThemChiTietHoaDon.Name = "btn_ThemChiTietHoaDon";
            this.btn_ThemChiTietHoaDon.Size = new System.Drawing.Size(97, 37);
            this.btn_ThemChiTietHoaDon.TabIndex = 30;
            this.btn_ThemChiTietHoaDon.Text = "Thêm";
            this.btn_ThemChiTietHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemChiTietHoaDon.UseVisualStyleBackColor = false;
            this.btn_ThemChiTietHoaDon.Click += new System.EventHandler(this.btn_ThemChiTietHoaDon_Click);
            // 
            // btn_CapNhatChiTietHoaDon
            // 
            this.btn_CapNhatChiTietHoaDon.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CapNhatChiTietHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_CapNhatChiTietHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhatChiTietHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhatChiTietHoaDon.Image = global::FashionShopApp.Properties.Resources.updated;
            this.btn_CapNhatChiTietHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhatChiTietHoaDon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_CapNhatChiTietHoaDon.Location = new System.Drawing.Point(255, 207);
            this.btn_CapNhatChiTietHoaDon.Name = "btn_CapNhatChiTietHoaDon";
            this.btn_CapNhatChiTietHoaDon.Size = new System.Drawing.Size(145, 37);
            this.btn_CapNhatChiTietHoaDon.TabIndex = 34;
            this.btn_CapNhatChiTietHoaDon.Text = "Cập nhật";
            this.btn_CapNhatChiTietHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CapNhatChiTietHoaDon.UseVisualStyleBackColor = false;
            this.btn_CapNhatChiTietHoaDon.Click += new System.EventHandler(this.btn_CapNhatChiTietHoaDon_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(15, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_IdHoaDon);
            this.groupBox1.Controls.Add(this.nmud_SoLuong);
            this.groupBox1.Controls.Add(this.txt_DonGia);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbo_TenSanPham);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btn_ResetChiTietHoaDon);
            this.groupBox1.Controls.Add(this.btn_XoaChiTietHoaDon);
            this.groupBox1.Controls.Add(this.btn_ThemChiTietHoaDon);
            this.groupBox1.Controls.Add(this.btn_CapNhatChiTietHoaDon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(992, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 261);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết hóa đơn";
            // 
            // cbo_IdHoaDon
            // 
            this.cbo_IdHoaDon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_IdHoaDon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_IdHoaDon.DropDownHeight = 80;
            this.cbo_IdHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cbo_IdHoaDon.FormattingEnabled = true;
            this.cbo_IdHoaDon.IntegralHeight = false;
            this.cbo_IdHoaDon.Location = new System.Drawing.Point(194, 82);
            this.cbo_IdHoaDon.Name = "cbo_IdHoaDon";
            this.cbo_IdHoaDon.Size = new System.Drawing.Size(328, 37);
            this.cbo_IdHoaDon.TabIndex = 43;
            // 
            // nmud_SoLuong
            // 
            this.nmud_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.nmud_SoLuong.Location = new System.Drawing.Point(130, 142);
            this.nmud_SoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmud_SoLuong.Name = "nmud_SoLuong";
            this.nmud_SoLuong.Size = new System.Drawing.Size(78, 34);
            this.nmud_SoLuong.TabIndex = 42;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_DonGia.Location = new System.Drawing.Point(339, 142);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.ReadOnly = true;
            this.txt_DonGia.Size = new System.Drawing.Size(180, 34);
            this.txt_DonGia.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(232, 144);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 29);
            this.label14.TabIndex = 40;
            this.label14.Text = "Đơn giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(15, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 29);
            this.label11.TabIndex = 39;
            this.label11.Text = "Số lượng";
            // 
            // cbo_TenSanPham
            // 
            this.cbo_TenSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_TenSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_TenSanPham.DropDownHeight = 80;
            this.cbo_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.cbo_TenSanPham.FormattingEnabled = true;
            this.cbo_TenSanPham.IntegralHeight = false;
            this.cbo_TenSanPham.Location = new System.Drawing.Point(194, 31);
            this.cbo_TenSanPham.Name = "cbo_TenSanPham";
            this.cbo_TenSanPham.Size = new System.Drawing.Size(328, 37);
            this.cbo_TenSanPham.TabIndex = 38;
            this.cbo_TenSanPham.SelectedValueChanged += new System.EventHandler(this.cbo_TenSanPham_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(15, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 29);
            this.label12.TabIndex = 37;
            this.label12.Text = "Sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(565, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 51);
            this.label1.TabIndex = 34;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 641);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmud_SoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsv_DanhSachHoaDon;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_ResetHoaDon;
        private System.Windows.Forms.Button btn_XoaHoaDon;
        private System.Windows.Forms.Button btn_CapNhatHoaDon;
        private System.Windows.Forms.Button btn_ThemHoaDon;
        private System.Windows.Forms.ComboBox cbo_ChiNhanh;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_IdHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lsv_ChiTietHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ResetChiTietHoaDon;
        private System.Windows.Forms.Button btn_XoaChiTietHoaDon;
        private System.Windows.Forms.Button btn_ThemChiTietHoaDon;
        private System.Windows.Forms.Button btn_CapNhatChiTietHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cbo_NhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_TenSanPham;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nmud_SoLuong;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ComboBox cbo_PtThanhToan;
        private System.Windows.Forms.ComboBox cbo_IdHoaDon;
        private System.Windows.Forms.DateTimePicker dtp_NgayXuatHoaDon;
    }
}