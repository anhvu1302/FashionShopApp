namespace FashionShopApp.GUI
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.ch_Doanhso = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ch_SanPham = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtp_soluong = new System.Windows.Forms.DateTimePicker();
            this.dtp_DoanhThu = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Doanhso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // ch_Doanhso
            // 
            chartArea5.Name = "ChartArea1";
            this.ch_Doanhso.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ch_Doanhso.Legends.Add(legend5);
            this.ch_Doanhso.Location = new System.Drawing.Point(37, 60);
            this.ch_Doanhso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ch_Doanhso.Name = "ch_Doanhso";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.ch_Doanhso.Series.Add(series5);
            this.ch_Doanhso.Size = new System.Drawing.Size(660, 581);
            this.ch_Doanhso.TabIndex = 0;
            this.ch_Doanhso.Text = "chart1";
            // 
            // ch_SanPham
            // 
            chartArea6.Name = "ChartArea1";
            this.ch_SanPham.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.ch_SanPham.Legends.Add(legend6);
            this.ch_SanPham.Location = new System.Drawing.Point(753, 60);
            this.ch_SanPham.Name = "ch_SanPham";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.ch_SanPham.Series.Add(series6);
            this.ch_SanPham.Size = new System.Drawing.Size(753, 581);
            this.ch_SanPham.TabIndex = 1;
            this.ch_SanPham.Text = "chart1";
            // 
            // dtp_soluong
            // 
            this.dtp_soluong.Location = new System.Drawing.Point(833, 13);
            this.dtp_soluong.Name = "dtp_soluong";
            this.dtp_soluong.Size = new System.Drawing.Size(345, 30);
            this.dtp_soluong.TabIndex = 2;
            this.dtp_soluong.ValueChanged += new System.EventHandler(this.dtp_soluong_ValueChanged);
            // 
            // dtp_DoanhThu
            // 
            this.dtp_DoanhThu.Location = new System.Drawing.Point(135, 13);
            this.dtp_DoanhThu.Name = "dtp_DoanhThu";
            this.dtp_DoanhThu.Size = new System.Drawing.Size(345, 30);
            this.dtp_DoanhThu.TabIndex = 2;
            this.dtp_DoanhThu.ValueChanged += new System.EventHandler(this.dtp_DoanhThu_ValueChanged);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 688);
            this.ControlBox = false;
            this.Controls.Add(this.dtp_DoanhThu);
            this.Controls.Add(this.dtp_soluong);
            this.Controls.Add(this.ch_SanPham);
            this.Controls.Add(this.ch_Doanhso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ch_Doanhso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch_SanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Doanhso;
        private System.Windows.Forms.DataVisualization.Charting.Chart ch_SanPham;
        private System.Windows.Forms.DateTimePicker dtp_soluong;
        private System.Windows.Forms.DateTimePicker dtp_DoanhThu;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}