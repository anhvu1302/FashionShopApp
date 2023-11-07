namespace FashionShopApp.GUI
{
    partial class frmLoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_ResetLoaiSpCha = new System.Windows.Forms.Button();
            this.btn_XoaLoaiSpCha = new System.Windows.Forms.Button();
            this.btn_ThemLoaiSpCha = new System.Windows.Forms.Button();
            this.btn_CapNhatLoaiSpCha = new System.Windows.Forms.Button();
            this.txt_TenLoaiSanPhamCha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IdLoaiSanPhamCha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsv_LoaiSanPhamCha = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_ResetLoaiSp = new System.Windows.Forms.Button();
            this.btn_XoaLoaiSp = new System.Windows.Forms.Button();
            this.btn_CapNhatLoaiSp = new System.Windows.Forms.Button();
            this.btn_ThemLoaiSp = new System.Windows.Forms.Button();
            this.cbo_LoaiSanPhamCha = new System.Windows.Forms.ComboBox();
            this.txt_TenLoaiSanPham = new System.Windows.Forms.TextBox();
            this.txt_IdLoaiSanPham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lsv_LoaiSanPham = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(566, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 51);
            this.label1.TabIndex = 30;
            this.label1.Text = "QUẢN LÝ LOẠI SẢN PHẨM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ResetLoaiSpCha);
            this.groupBox1.Controls.Add(this.btn_XoaLoaiSpCha);
            this.groupBox1.Controls.Add(this.btn_ThemLoaiSpCha);
            this.groupBox1.Controls.Add(this.btn_CapNhatLoaiSpCha);
            this.groupBox1.Controls.Add(this.txt_TenLoaiSanPhamCha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_IdLoaiSanPhamCha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 225);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại sản phẩm cha";
            // 
            // btn_ResetLoaiSpCha
            // 
            this.btn_ResetLoaiSpCha.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ResetLoaiSpCha.FlatAppearance.BorderSize = 0;
            this.btn_ResetLoaiSpCha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetLoaiSpCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ResetLoaiSpCha.Image = ((System.Drawing.Image)(resources.GetObject("btn_ResetLoaiSpCha.Image")));
            this.btn_ResetLoaiSpCha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ResetLoaiSpCha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ResetLoaiSpCha.Location = new System.Drawing.Point(11, 162);
            this.btn_ResetLoaiSpCha.Name = "btn_ResetLoaiSpCha";
            this.btn_ResetLoaiSpCha.Size = new System.Drawing.Size(94, 37);
            this.btn_ResetLoaiSpCha.TabIndex = 36;
            this.btn_ResetLoaiSpCha.Text = "Reset";
            this.btn_ResetLoaiSpCha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ResetLoaiSpCha.UseVisualStyleBackColor = false;
            this.btn_ResetLoaiSpCha.Click += new System.EventHandler(this.btn_ResetLoaiSpCha_Click);
            // 
            // btn_XoaLoaiSpCha
            // 
            this.btn_XoaLoaiSpCha.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_XoaLoaiSpCha.FlatAppearance.BorderSize = 0;
            this.btn_XoaLoaiSpCha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaLoaiSpCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_XoaLoaiSpCha.Image = global::FashionShopApp.Properties.Resources.delete;
            this.btn_XoaLoaiSpCha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaLoaiSpCha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_XoaLoaiSpCha.Location = new System.Drawing.Point(432, 162);
            this.btn_XoaLoaiSpCha.Name = "btn_XoaLoaiSpCha";
            this.btn_XoaLoaiSpCha.Size = new System.Drawing.Size(103, 37);
            this.btn_XoaLoaiSpCha.TabIndex = 32;
            this.btn_XoaLoaiSpCha.Text = "Xóa";
            this.btn_XoaLoaiSpCha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaLoaiSpCha.UseVisualStyleBackColor = false;
            this.btn_XoaLoaiSpCha.Click += new System.EventHandler(this.btn_XoaLoaiSpCha_Click);
            // 
            // btn_ThemLoaiSpCha
            // 
            this.btn_ThemLoaiSpCha.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ThemLoaiSpCha.FlatAppearance.BorderSize = 0;
            this.btn_ThemLoaiSpCha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemLoaiSpCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ThemLoaiSpCha.Image = global::FashionShopApp.Properties.Resources.add;
            this.btn_ThemLoaiSpCha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemLoaiSpCha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThemLoaiSpCha.Location = new System.Drawing.Point(136, 162);
            this.btn_ThemLoaiSpCha.Name = "btn_ThemLoaiSpCha";
            this.btn_ThemLoaiSpCha.Size = new System.Drawing.Size(97, 37);
            this.btn_ThemLoaiSpCha.TabIndex = 30;
            this.btn_ThemLoaiSpCha.Text = "Thêm";
            this.btn_ThemLoaiSpCha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemLoaiSpCha.UseVisualStyleBackColor = false;
            this.btn_ThemLoaiSpCha.Click += new System.EventHandler(this.btn_ThemLoaiSpCha_Click);
            // 
            // btn_CapNhatLoaiSpCha
            // 
            this.btn_CapNhatLoaiSpCha.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CapNhatLoaiSpCha.FlatAppearance.BorderSize = 0;
            this.btn_CapNhatLoaiSpCha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhatLoaiSpCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhatLoaiSpCha.Image = global::FashionShopApp.Properties.Resources.updated;
            this.btn_CapNhatLoaiSpCha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhatLoaiSpCha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_CapNhatLoaiSpCha.Location = new System.Drawing.Point(267, 161);
            this.btn_CapNhatLoaiSpCha.Name = "btn_CapNhatLoaiSpCha";
            this.btn_CapNhatLoaiSpCha.Size = new System.Drawing.Size(145, 37);
            this.btn_CapNhatLoaiSpCha.TabIndex = 34;
            this.btn_CapNhatLoaiSpCha.Text = "Cập nhật";
            this.btn_CapNhatLoaiSpCha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CapNhatLoaiSpCha.UseVisualStyleBackColor = false;
            this.btn_CapNhatLoaiSpCha.Click += new System.EventHandler(this.btn_CapNhatLoaiSpCha_Click);
            // 
            // txt_TenLoaiSanPhamCha
            // 
            this.txt_TenLoaiSanPhamCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLoaiSanPhamCha.Location = new System.Drawing.Point(267, 91);
            this.txt_TenLoaiSanPhamCha.Name = "txt_TenLoaiSanPhamCha";
            this.txt_TenLoaiSanPhamCha.Size = new System.Drawing.Size(202, 34);
            this.txt_TenLoaiSanPhamCha.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên loại sản phẩm cha";
            // 
            // txt_IdLoaiSanPhamCha
            // 
            this.txt_IdLoaiSanPhamCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdLoaiSanPhamCha.Location = new System.Drawing.Point(267, 26);
            this.txt_IdLoaiSanPhamCha.Name = "txt_IdLoaiSanPhamCha";
            this.txt_IdLoaiSanPhamCha.ReadOnly = true;
            this.txt_IdLoaiSanPhamCha.Size = new System.Drawing.Size(202, 34);
            this.txt_IdLoaiSanPhamCha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã loại sản phẩm cha";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsv_LoaiSanPhamCha);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 291);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại sản phẩm cha";
            // 
            // lsv_LoaiSanPhamCha
            // 
            this.lsv_LoaiSanPhamCha.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsv_LoaiSanPhamCha.FullRowSelect = true;
            this.lsv_LoaiSanPhamCha.HideSelection = false;
            this.lsv_LoaiSanPhamCha.Location = new System.Drawing.Point(25, 39);
            this.lsv_LoaiSanPhamCha.MultiSelect = false;
            this.lsv_LoaiSanPhamCha.Name = "lsv_LoaiSanPhamCha";
            this.lsv_LoaiSanPhamCha.Size = new System.Drawing.Size(486, 236);
            this.lsv_LoaiSanPhamCha.TabIndex = 1;
            this.lsv_LoaiSanPhamCha.UseCompatibleStateImageBehavior = false;
            this.lsv_LoaiSanPhamCha.View = System.Windows.Forms.View.Details;
            this.lsv_LoaiSanPhamCha.SelectedIndexChanged += new System.EventHandler(this.lsv_LoaiSanPhamCha_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã loại sản phẩm cha";
            this.columnHeader1.Width = 189;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên loại sản phẩm cha";
            this.columnHeader2.Width = 218;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_ResetLoaiSp);
            this.groupBox3.Controls.Add(this.btn_XoaLoaiSp);
            this.groupBox3.Controls.Add(this.btn_CapNhatLoaiSp);
            this.groupBox3.Controls.Add(this.btn_ThemLoaiSp);
            this.groupBox3.Controls.Add(this.cbo_LoaiSanPhamCha);
            this.groupBox3.Controls.Add(this.txt_TenLoaiSanPham);
            this.groupBox3.Controls.Add(this.txt_IdLoaiSanPham);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(643, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(860, 225);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin loại sản phẩm";
            // 
            // btn_ResetLoaiSp
            // 
            this.btn_ResetLoaiSp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ResetLoaiSp.FlatAppearance.BorderSize = 0;
            this.btn_ResetLoaiSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetLoaiSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ResetLoaiSp.Image = ((System.Drawing.Image)(resources.GetObject("btn_ResetLoaiSp.Image")));
            this.btn_ResetLoaiSp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ResetLoaiSp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ResetLoaiSp.Location = new System.Drawing.Point(80, 164);
            this.btn_ResetLoaiSp.Name = "btn_ResetLoaiSp";
            this.btn_ResetLoaiSp.Size = new System.Drawing.Size(121, 37);
            this.btn_ResetLoaiSp.TabIndex = 36;
            this.btn_ResetLoaiSp.Text = "Reset";
            this.btn_ResetLoaiSp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ResetLoaiSp.UseVisualStyleBackColor = false;
            this.btn_ResetLoaiSp.Click += new System.EventHandler(this.btn_ResetLoaiSp_Click);
            // 
            // btn_XoaLoaiSp
            // 
            this.btn_XoaLoaiSp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_XoaLoaiSp.FlatAppearance.BorderSize = 0;
            this.btn_XoaLoaiSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XoaLoaiSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaLoaiSp.Image = global::FashionShopApp.Properties.Resources.delete;
            this.btn_XoaLoaiSp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_XoaLoaiSp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_XoaLoaiSp.Location = new System.Drawing.Point(687, 164);
            this.btn_XoaLoaiSp.Name = "btn_XoaLoaiSp";
            this.btn_XoaLoaiSp.Size = new System.Drawing.Size(103, 37);
            this.btn_XoaLoaiSp.TabIndex = 35;
            this.btn_XoaLoaiSp.Text = "Xóa";
            this.btn_XoaLoaiSp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_XoaLoaiSp.UseVisualStyleBackColor = false;
            this.btn_XoaLoaiSp.Click += new System.EventHandler(this.btn_XoaLoaiSp_Click);
            // 
            // btn_CapNhatLoaiSp
            // 
            this.btn_CapNhatLoaiSp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CapNhatLoaiSp.FlatAppearance.BorderSize = 0;
            this.btn_CapNhatLoaiSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhatLoaiSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_CapNhatLoaiSp.Image = global::FashionShopApp.Properties.Resources.updated;
            this.btn_CapNhatLoaiSp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhatLoaiSp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_CapNhatLoaiSp.Location = new System.Drawing.Point(469, 164);
            this.btn_CapNhatLoaiSp.Name = "btn_CapNhatLoaiSp";
            this.btn_CapNhatLoaiSp.Size = new System.Drawing.Size(140, 37);
            this.btn_CapNhatLoaiSp.TabIndex = 31;
            this.btn_CapNhatLoaiSp.Text = "Cập nhật";
            this.btn_CapNhatLoaiSp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CapNhatLoaiSp.UseVisualStyleBackColor = false;
            this.btn_CapNhatLoaiSp.Click += new System.EventHandler(this.btn_CapNhatLoaiSp_Click);
            // 
            // btn_ThemLoaiSp
            // 
            this.btn_ThemLoaiSp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ThemLoaiSp.FlatAppearance.BorderSize = 0;
            this.btn_ThemLoaiSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemLoaiSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemLoaiSp.Image = global::FashionShopApp.Properties.Resources.add;
            this.btn_ThemLoaiSp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemLoaiSp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ThemLoaiSp.Location = new System.Drawing.Point(278, 164);
            this.btn_ThemLoaiSp.Name = "btn_ThemLoaiSp";
            this.btn_ThemLoaiSp.Size = new System.Drawing.Size(113, 37);
            this.btn_ThemLoaiSp.TabIndex = 33;
            this.btn_ThemLoaiSp.Text = "Thêm";
            this.btn_ThemLoaiSp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ThemLoaiSp.UseVisualStyleBackColor = false;
            this.btn_ThemLoaiSp.Click += new System.EventHandler(this.btn_ThemLoaiSp_Click);
            // 
            // cbo_LoaiSanPhamCha
            // 
            this.cbo_LoaiSanPhamCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiSanPhamCha.FormattingEnabled = true;
            this.cbo_LoaiSanPhamCha.Location = new System.Drawing.Point(660, 26);
            this.cbo_LoaiSanPhamCha.Name = "cbo_LoaiSanPhamCha";
            this.cbo_LoaiSanPhamCha.Size = new System.Drawing.Size(168, 37);
            this.cbo_LoaiSanPhamCha.TabIndex = 2;
            // 
            // txt_TenLoaiSanPham
            // 
            this.txt_TenLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenLoaiSanPham.Location = new System.Drawing.Point(425, 88);
            this.txt_TenLoaiSanPham.Name = "txt_TenLoaiSanPham";
            this.txt_TenLoaiSanPham.Size = new System.Drawing.Size(298, 34);
            this.txt_TenLoaiSanPham.TabIndex = 1;
            // 
            // txt_IdLoaiSanPham
            // 
            this.txt_IdLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdLoaiSanPham.Location = new System.Drawing.Point(236, 26);
            this.txt_IdLoaiSanPham.Name = "txt_IdLoaiSanPham";
            this.txt_IdLoaiSanPham.ReadOnly = true;
            this.txt_IdLoaiSanPham.Size = new System.Drawing.Size(168, 34);
            this.txt_IdLoaiSanPham.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label6.Location = new System.Drawing.Point(441, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Loại sản phẩm cha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label5.Location = new System.Drawing.Point(164, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên loại sản phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label4.Location = new System.Drawing.Point(29, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã loại sản phẩm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsv_LoaiSanPham);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(643, 318);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(860, 291);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách loại sản phẩm";
            // 
            // lsv_LoaiSanPham
            // 
            this.lsv_LoaiSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsv_LoaiSanPham.FullRowSelect = true;
            this.lsv_LoaiSanPham.HideSelection = false;
            this.lsv_LoaiSanPham.Location = new System.Drawing.Point(34, 39);
            this.lsv_LoaiSanPham.MultiSelect = false;
            this.lsv_LoaiSanPham.Name = "lsv_LoaiSanPham";
            this.lsv_LoaiSanPham.Size = new System.Drawing.Size(794, 236);
            this.lsv_LoaiSanPham.TabIndex = 2;
            this.lsv_LoaiSanPham.UseCompatibleStateImageBehavior = false;
            this.lsv_LoaiSanPham.View = System.Windows.Forms.View.Details;
            this.lsv_LoaiSanPham.SelectedIndexChanged += new System.EventHandler(this.lsv_LoaiSanPham_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã loại sản phẩm";
            this.columnHeader3.Width = 184;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên loại sản phẩm";
            this.columnHeader4.Width = 186;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Loại sản phẩm cha";
            this.columnHeader5.Width = 253;
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1539, 641);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoaiSanPham";
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_TenLoaiSanPhamCha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdLoaiSanPhamCha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_XoaLoaiSpCha;
        private System.Windows.Forms.Button btn_CapNhatLoaiSp;
        private System.Windows.Forms.Button btn_ThemLoaiSpCha;
        private System.Windows.Forms.ListView lsv_LoaiSanPhamCha;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cbo_LoaiSanPhamCha;
        private System.Windows.Forms.TextBox txt_TenLoaiSanPham;
        private System.Windows.Forms.TextBox txt_IdLoaiSanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lsv_LoaiSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btn_XoaLoaiSp;
        private System.Windows.Forms.Button btn_CapNhatLoaiSpCha;
        private System.Windows.Forms.Button btn_ThemLoaiSp;
        private System.Windows.Forms.Button btn_ResetLoaiSpCha;
        private System.Windows.Forms.Button btn_ResetLoaiSp;
    }
}