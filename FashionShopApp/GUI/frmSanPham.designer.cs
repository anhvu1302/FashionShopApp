namespace FashionShopApp.GUI
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsv_SanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_ThanhToanVanChuyen = new System.Windows.Forms.TextBox();
            this.cbo_LoaiSanPham = new System.Windows.Forms.ComboBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btnThemSanPham = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_OpenImage3 = new System.Windows.Forms.Button();
            this.btn_OpenImage2 = new System.Windows.Forms.Button();
            this.btn_OpenImage1 = new System.Windows.Forms.Button();
            this.cbo_TonTai = new System.Windows.Forms.ComboBox();
            this.nmud_GiamGia = new System.Windows.Forms.NumericUpDown();
            this.ptb_Image3 = new System.Windows.Forms.PictureBox();
            this.ptb_Image2 = new System.Windows.Forms.PictureBox();
            this.ptb_Image1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DanhGiaSanPham = new System.Windows.Forms.TextBox();
            this.txt_NoiDungSanPham = new System.Windows.Forms.TextBox();
            this.txt_SoLuongDanhGia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TenSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IdSanPham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmud_GiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(549, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 51);
            this.label1.TabIndex = 29;
            this.label1.Text = "QUẢN LÝ SẢN PHẨM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Controls.Add(this.lsv_SanPham);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1531, 261);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // lsv_SanPham
            // 
            this.lsv_SanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lsv_SanPham.FullRowSelect = true;
            this.lsv_SanPham.HideSelection = false;
            this.lsv_SanPham.Location = new System.Drawing.Point(6, 26);
            this.lsv_SanPham.MultiSelect = false;
            this.lsv_SanPham.Name = "lsv_SanPham";
            this.lsv_SanPham.Size = new System.Drawing.Size(1519, 224);
            this.lsv_SanPham.TabIndex = 0;
            this.lsv_SanPham.UseCompatibleStateImageBehavior = false;
            this.lsv_SanPham.View = System.Windows.Forms.View.Details;
            this.lsv_SanPham.SelectedIndexChanged += new System.EventHandler(this.lsv_SanPham_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            this.columnHeader1.Width = 117;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại sản phẩm";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ảnh";
            this.columnHeader4.Width = 65;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ảnh 2";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ảnh 3";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Giá bán";
            this.columnHeader7.Width = 88;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giảm giá";
            this.columnHeader8.Width = 81;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Số lượng đánh giá";
            this.columnHeader9.Width = 151;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nội dung sản phẩm";
            this.columnHeader10.Width = 162;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Đánh giá sản phẩm";
            this.columnHeader11.Width = 161;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Thanh toán vận chuyển";
            this.columnHeader12.Width = 133;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Trạng thái";
            this.columnHeader13.Width = 106;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ThanhToanVanChuyen);
            this.groupBox2.Controls.Add(this.cbo_LoaiSanPham);
            this.groupBox2.Controls.Add(this.btn_Reset);
            this.groupBox2.Controls.Add(this.btn_CapNhat);
            this.groupBox2.Controls.Add(this.btnThemSanPham);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btn_OpenImage3);
            this.groupBox2.Controls.Add(this.btn_OpenImage2);
            this.groupBox2.Controls.Add(this.btn_OpenImage1);
            this.groupBox2.Controls.Add(this.cbo_TonTai);
            this.groupBox2.Controls.Add(this.nmud_GiamGia);
            this.groupBox2.Controls.Add(this.ptb_Image3);
            this.groupBox2.Controls.Add(this.ptb_Image2);
            this.groupBox2.Controls.Add(this.ptb_Image1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_DanhGiaSanPham);
            this.groupBox2.Controls.Add(this.txt_NoiDungSanPham);
            this.groupBox2.Controls.Add(this.txt_SoLuongDanhGia);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtGiaBan);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_TenSanPham);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_IdSanPham);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(18, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1525, 332);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sản phẩm";
            // 
            // txt_ThanhToanVanChuyen
            // 
            this.txt_ThanhToanVanChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ThanhToanVanChuyen.Location = new System.Drawing.Point(1242, 128);
            this.txt_ThanhToanVanChuyen.Multiline = true;
            this.txt_ThanhToanVanChuyen.Name = "txt_ThanhToanVanChuyen";
            this.txt_ThanhToanVanChuyen.Size = new System.Drawing.Size(263, 112);
            this.txt_ThanhToanVanChuyen.TabIndex = 32;
            // 
            // cbo_LoaiSanPham
            // 
            this.cbo_LoaiSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbo_LoaiSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_LoaiSanPham.DropDownHeight = 80;
            this.cbo_LoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiSanPham.FormattingEnabled = true;
            this.cbo_LoaiSanPham.IntegralHeight = false;
            this.cbo_LoaiSanPham.Location = new System.Drawing.Point(484, 23);
            this.cbo_LoaiSanPham.Name = "cbo_LoaiSanPham";
            this.cbo_LoaiSanPham.Size = new System.Drawing.Size(180, 33);
            this.cbo_LoaiSanPham.TabIndex = 30;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_Reset.Image")));
            this.btn_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Reset.Location = new System.Drawing.Point(813, 271);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(121, 37);
            this.btn_Reset.TabIndex = 29;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CapNhat.FlatAppearance.BorderSize = 0;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CapNhat.Image = global::FashionShopApp.Properties.Resources.updated;
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_CapNhat.Location = new System.Drawing.Point(1002, 271);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(213, 37);
            this.btn_CapNhat.TabIndex = 28;
            this.btn_CapNhat.Text = "Cập nhật thông tin";
            this.btn_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btnThemSanPham
            // 
            this.btnThemSanPham.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThemSanPham.FlatAppearance.BorderSize = 0;
            this.btnThemSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThemSanPham.Image = global::FashionShopApp.Properties.Resources.add;
            this.btnThemSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSanPham.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThemSanPham.Location = new System.Drawing.Point(1282, 271);
            this.btnThemSanPham.Name = "btnThemSanPham";
            this.btnThemSanPham.Size = new System.Drawing.Size(195, 37);
            this.btnThemSanPham.TabIndex = 27;
            this.btnThemSanPham.Text = "Thêm sản phẩm";
            this.btnThemSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSanPham.UseVisualStyleBackColor = false;
            this.btnThemSanPham.Click += new System.EventHandler(this.btnThemSanPham_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1251, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(218, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Thanh toán vận chuyển";
            // 
            // btn_OpenImage3
            // 
            this.btn_OpenImage3.BackColor = System.Drawing.SystemColors.Control;
            this.btn_OpenImage3.FlatAppearance.BorderSize = 0;
            this.btn_OpenImage3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenImage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenImage3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_OpenImage3.Location = new System.Drawing.Point(449, 293);
            this.btn_OpenImage3.Name = "btn_OpenImage3";
            this.btn_OpenImage3.Size = new System.Drawing.Size(104, 29);
            this.btn_OpenImage3.TabIndex = 24;
            this.btn_OpenImage3.Text = "Open file";
            this.btn_OpenImage3.UseVisualStyleBackColor = false;
            this.btn_OpenImage3.Click += new System.EventHandler(this.btn_OpenImage3_Click);
            // 
            // btn_OpenImage2
            // 
            this.btn_OpenImage2.BackColor = System.Drawing.SystemColors.Control;
            this.btn_OpenImage2.FlatAppearance.BorderSize = 0;
            this.btn_OpenImage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenImage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenImage2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_OpenImage2.Location = new System.Drawing.Point(251, 293);
            this.btn_OpenImage2.Name = "btn_OpenImage2";
            this.btn_OpenImage2.Size = new System.Drawing.Size(104, 29);
            this.btn_OpenImage2.TabIndex = 24;
            this.btn_OpenImage2.Text = "Open file";
            this.btn_OpenImage2.UseVisualStyleBackColor = false;
            this.btn_OpenImage2.Click += new System.EventHandler(this.btn_OpenImage2_Click);
            // 
            // btn_OpenImage1
            // 
            this.btn_OpenImage1.BackColor = System.Drawing.SystemColors.Control;
            this.btn_OpenImage1.FlatAppearance.BorderSize = 0;
            this.btn_OpenImage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OpenImage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenImage1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_OpenImage1.Location = new System.Drawing.Point(47, 293);
            this.btn_OpenImage1.Name = "btn_OpenImage1";
            this.btn_OpenImage1.Size = new System.Drawing.Size(104, 29);
            this.btn_OpenImage1.TabIndex = 23;
            this.btn_OpenImage1.Text = "Open file";
            this.btn_OpenImage1.UseVisualStyleBackColor = false;
            this.btn_OpenImage1.Click += new System.EventHandler(this.btn_OpenImage1_Click);
            // 
            // cbo_TonTai
            // 
            this.cbo_TonTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_TonTai.FormattingEnabled = true;
            this.cbo_TonTai.Location = new System.Drawing.Point(484, 75);
            this.cbo_TonTai.Name = "cbo_TonTai";
            this.cbo_TonTai.Size = new System.Drawing.Size(180, 33);
            this.cbo_TonTai.TabIndex = 5;
            // 
            // nmud_GiamGia
            // 
            this.nmud_GiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmud_GiamGia.Location = new System.Drawing.Point(1047, 21);
            this.nmud_GiamGia.Name = "nmud_GiamGia";
            this.nmud_GiamGia.Size = new System.Drawing.Size(112, 30);
            this.nmud_GiamGia.TabIndex = 4;
            // 
            // ptb_Image3
            // 
            this.ptb_Image3.Location = new System.Drawing.Point(437, 122);
            this.ptb_Image3.Name = "ptb_Image3";
            this.ptb_Image3.Size = new System.Drawing.Size(132, 165);
            this.ptb_Image3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Image3.TabIndex = 2;
            this.ptb_Image3.TabStop = false;
            // 
            // ptb_Image2
            // 
            this.ptb_Image2.Location = new System.Drawing.Point(238, 122);
            this.ptb_Image2.Name = "ptb_Image2";
            this.ptb_Image2.Size = new System.Drawing.Size(132, 165);
            this.ptb_Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Image2.TabIndex = 2;
            this.ptb_Image2.TabStop = false;
            // 
            // ptb_Image1
            // 
            this.ptb_Image1.Location = new System.Drawing.Point(29, 122);
            this.ptb_Image1.Name = "ptb_Image1";
            this.ptb_Image1.Size = new System.Drawing.Size(132, 165);
            this.ptb_Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Image1.TabIndex = 2;
            this.ptb_Image1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại sản phẩm";
            // 
            // txt_DanhGiaSanPham
            // 
            this.txt_DanhGiaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DanhGiaSanPham.Location = new System.Drawing.Point(949, 128);
            this.txt_DanhGiaSanPham.Multiline = true;
            this.txt_DanhGiaSanPham.Name = "txt_DanhGiaSanPham";
            this.txt_DanhGiaSanPham.Size = new System.Drawing.Size(266, 112);
            this.txt_DanhGiaSanPham.TabIndex = 1;
            // 
            // txt_NoiDungSanPham
            // 
            this.txt_NoiDungSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoiDungSanPham.Location = new System.Drawing.Point(590, 128);
            this.txt_NoiDungSanPham.Multiline = true;
            this.txt_NoiDungSanPham.Name = "txt_NoiDungSanPham";
            this.txt_NoiDungSanPham.Size = new System.Drawing.Size(331, 112);
            this.txt_NoiDungSanPham.TabIndex = 1;
            // 
            // txt_SoLuongDanhGia
            // 
            this.txt_SoLuongDanhGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongDanhGia.Location = new System.Drawing.Point(1375, 26);
            this.txt_SoLuongDanhGia.Name = "txt_SoLuongDanhGia";
            this.txt_SoLuongDanhGia.ReadOnly = true;
            this.txt_SoLuongDanhGia.Size = new System.Drawing.Size(130, 30);
            this.txt_SoLuongDanhGia.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(944, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Đánh giá sản phẩm";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(792, 26);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(129, 30);
            this.txtGiaBan.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(336, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tồn tại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(694, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nội dung sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1182, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng đánh giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(944, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giảm giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(694, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá bán";
            // 
            // txt_TenSanPham
            // 
            this.txt_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenSanPham.Location = new System.Drawing.Point(160, 75);
            this.txt_TenSanPham.Name = "txt_TenSanPham";
            this.txt_TenSanPham.Size = new System.Drawing.Size(139, 30);
            this.txt_TenSanPham.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sản phẩm";
            // 
            // txt_IdSanPham
            // 
            this.txt_IdSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdSanPham.Location = new System.Drawing.Point(160, 26);
            this.txt_IdSanPham.Name = "txt_IdSanPham";
            this.txt_IdSanPham.ReadOnly = true;
            this.txt_IdSanPham.Size = new System.Drawing.Size(139, 30);
            this.txt_IdSanPham.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(410, 71);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(979, 140);
            this.dgv.TabIndex = 1;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 688);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSanPham";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmud_GiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Image1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsv_SanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ptb_Image3;
        private System.Windows.Forms.PictureBox ptb_Image2;
        private System.Windows.Forms.PictureBox ptb_Image1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdSanPham;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmud_GiamGia;
        private System.Windows.Forms.TextBox txt_NoiDungSanPham;
        private System.Windows.Forms.TextBox txt_SoLuongDanhGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DanhGiaSanPham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_TonTai;
        private System.Windows.Forms.Button btn_OpenImage3;
        private System.Windows.Forms.Button btn_OpenImage2;
        private System.Windows.Forms.Button btn_OpenImage1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThemSanPham;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.ComboBox cbo_LoaiSanPham;
        private System.Windows.Forms.TextBox txt_ThanhToanVanChuyen;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.DataGridView dgv;
    }
}