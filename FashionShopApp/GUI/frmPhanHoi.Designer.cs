namespace FashionShopApp
{
    partial class frmPhanHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanHoi));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cboVanDe = new System.Windows.Forms.ComboBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.r_NDVanDe = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_maPhanHoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenKH = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_RsRichtxt = new System.Windows.Forms.Button();
            this.dtp_phanhoi = new System.Windows.Forms.DateTimePicker();
            this.btn_Gui = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ResetTextBox = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(886, 55);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(605, 504);
            this.dgv.TabIndex = 1;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.Click += new System.EventHandler(this.dgv_Click);
            // 
            // cboVanDe
            // 
            this.cboVanDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVanDe.FormattingEnabled = true;
            this.cboVanDe.Items.AddRange(new object[] {
            "Sản Phẩm",
            "Dịch vụ",
            "Mua hàng không thành công",
            "Giao hàng",
            "Vận chuyển",
            "Phục vụ",
            "Thanh toán",
            "Giao hàng",
            "Khác"});
            this.cboVanDe.Location = new System.Drawing.Point(195, 101);
            this.cboVanDe.Name = "cboVanDe";
            this.cboVanDe.Size = new System.Drawing.Size(144, 34);
            this.cboVanDe.TabIndex = 2;
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_makh.Location = new System.Drawing.Point(207, 131);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(175, 34);
            this.txt_makh.TabIndex = 11;
            this.txt_makh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_makh_KeyPress);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_sdt.Location = new System.Drawing.Point(195, 51);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(175, 34);
            this.txt_sdt.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(3, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 25);
            this.label15.TabIndex = 50;
            this.label15.Text = "Số điện thoại";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(3, 98);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 25);
            this.label14.TabIndex = 49;
            this.label14.Text = "Vấn đề";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 25);
            this.label12.TabIndex = 47;
            this.label12.Text = "Tên khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(12, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 25);
            this.label10.TabIndex = 45;
            this.label10.Text = "Mã khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Nội dung vấn đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 63;
            this.label2.Text = "Thời gian phản hồi";
            // 
            // r_NDVanDe
            // 
            this.r_NDVanDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_NDVanDe.Location = new System.Drawing.Point(195, 152);
            this.r_NDVanDe.Name = "r_NDVanDe";
            this.r_NDVanDe.Size = new System.Drawing.Size(429, 81);
            this.r_NDVanDe.TabIndex = 8;
            this.r_NDVanDe.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.16627F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.83373F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_tenKH, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_sdt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cboVanDe, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_RsRichtxt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.r_NDVanDe, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtp_phanhoi, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Gui, 3, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 177);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.97959F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.02041F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 279);
            this.tableLayoutPanel1.TabIndex = 65;
            // 
            // txt_maPhanHoi
            // 
            this.txt_maPhanHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_maPhanHoi.Location = new System.Drawing.Point(207, 87);
            this.txt_maPhanHoi.Name = "txt_maPhanHoi";
            this.txt_maPhanHoi.Size = new System.Drawing.Size(175, 34);
            this.txt_maPhanHoi.TabIndex = 89;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 90;
            this.label3.Text = "Mã phản hồi";
            // 
            // txt_tenKH
            // 
            this.txt_tenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txt_tenKH.Location = new System.Drawing.Point(195, 3);
            this.txt_tenKH.Name = "txt_tenKH";
            this.txt_tenKH.Size = new System.Drawing.Size(175, 34);
            this.txt_tenKH.TabIndex = 3;
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Find.FlatAppearance.BorderSize = 0;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Find.Image = ((System.Drawing.Image)(resources.GetObject("btn_Find.Image")));
            this.btn_Find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Find.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Find.Location = new System.Drawing.Point(402, 136);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(84, 26);
            this.btn_Find.TabIndex = 88;
            this.btn_Find.Text = "Tìm";
            this.btn_Find.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_RsRichtxt
            // 
            this.btn_RsRichtxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_RsRichtxt.FlatAppearance.BorderSize = 0;
            this.btn_RsRichtxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RsRichtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_RsRichtxt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RsRichtxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_RsRichtxt.Location = new System.Drawing.Point(639, 152);
            this.btn_RsRichtxt.Name = "btn_RsRichtxt";
            this.btn_RsRichtxt.Size = new System.Drawing.Size(89, 37);
            this.btn_RsRichtxt.TabIndex = 88;
            this.btn_RsRichtxt.Text = "Refresh";
            this.btn_RsRichtxt.UseVisualStyleBackColor = false;
            this.btn_RsRichtxt.Click += new System.EventHandler(this.btn_RsRichtxt_Click);
            // 
            // dtp_phanhoi
            // 
            this.dtp_phanhoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_phanhoi.Location = new System.Drawing.Point(195, 239);
            this.dtp_phanhoi.Name = "dtp_phanhoi";
            this.dtp_phanhoi.Size = new System.Drawing.Size(200, 30);
            this.dtp_phanhoi.TabIndex = 91;
            // 
            // btn_Gui
            // 
            this.btn_Gui.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Gui.FlatAppearance.BorderSize = 0;
            this.btn_Gui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Gui.Image = global::FashionShopApp.Properties.Resources.add;
            this.btn_Gui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Gui.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Gui.Location = new System.Drawing.Point(734, 239);
            this.btn_Gui.Name = "btn_Gui";
            this.btn_Gui.Size = new System.Drawing.Size(105, 37);
            this.btn_Gui.TabIndex = 38;
            this.btn_Gui.Text = "Thêm";
            this.btn_Gui.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Gui.UseVisualStyleBackColor = false;
            this.btn_Gui.Click += new System.EventHandler(this.btn_Gui_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(54)))), ((int)(((byte)(137)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(394, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(773, 46);
            this.label4.TabIndex = 86;
            this.label4.Text = "QUẢN LÝ PHẢN HỒI CỦA KHÁCH HÀNG";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.22472F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.77528F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel2.Controls.Add(this.btn_ResetTextBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Xoa, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_CapNhat, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(48, 484);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(597, 50);
            this.tableLayoutPanel2.TabIndex = 87;
            // 
            // btn_ResetTextBox
            // 
            this.btn_ResetTextBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_ResetTextBox.FlatAppearance.BorderSize = 0;
            this.btn_ResetTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ResetTextBox.Image = ((System.Drawing.Image)(resources.GetObject("btn_ResetTextBox.Image")));
            this.btn_ResetTextBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ResetTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ResetTextBox.Location = new System.Drawing.Point(3, 3);
            this.btn_ResetTextBox.Name = "btn_ResetTextBox";
            this.btn_ResetTextBox.Size = new System.Drawing.Size(115, 37);
            this.btn_ResetTextBox.TabIndex = 37;
            this.btn_ResetTextBox.Text = "Làm mới";
            this.btn_ResetTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ResetTextBox.UseVisualStyleBackColor = false;
            this.btn_ResetTextBox.Click += new System.EventHandler(this.btn_ResetTextBox_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Image = global::FashionShopApp.Properties.Resources.delete;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Xoa.Location = new System.Drawing.Point(179, 3);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(91, 37);
            this.btn_Xoa.TabIndex = 39;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_CapNhat.FlatAppearance.BorderSize = 0;
            this.btn_CapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Image = global::FashionShopApp.Properties.Resources.updated;
            this.btn_CapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CapNhat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_CapNhat.Location = new System.Drawing.Point(299, 3);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(127, 37);
            this.btn_CapNhat.TabIndex = 40;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // frmPhanHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1555, 661);
            this.ControlBox = false;
            this.Controls.Add(this.txt_maPhanHoi);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txt_makh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgv);
            this.Name = "frmPhanHoi";
            this.Load += new System.EventHandler(this.frmPhanHoiKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cboVanDe;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox r_NDVanDe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_tenKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_ResetTextBox;
        private System.Windows.Forms.Button btn_Gui;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_RsRichtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maPhanHoi;
        private System.Windows.Forms.DateTimePicker dtp_phanhoi;
    }
}