using FashionShopApp.Model;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace FashionShopApp.GUI
{
    public partial class frmThongKe : Form
    {
        SQLConfig config = new SQLConfig(NguoiDungHienTai.CurentUser.nguoiDung.TenTaiKhoan, NguoiDungHienTai.CurentUser.nguoiDung.MatKhau);
        private string sql;

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy/MM/dd");

            //loadDoanhSo("2023/12/04");
            //loadSoSanPham(formattedDate);
        }
        void loadDoanhSo(string date)
        {
            ch_Doanhso.Series.Clear();
            ch_Doanhso.Series.Add("Doanh Thu");
            sql = "SELECT * FROM LoaiSanPhamCha";
            DataTable dt = config.ExecuteSelectQuery(sql);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    sql = string.Format("SELECT DBO.func_TinhDoanhSo({0},'{1}')", dr[0].ToString(), date);
                    Object result = config.ExecuteScalar(sql);
                    if (result == null)
                        return;
                    else
                    {
                        int soLuong = int.Parse(result.ToString());
                        ch_Doanhso.Series["Doanh Thu"].Points.AddXY(dr[1].ToString(), soLuong);
                    }

                }
            }
            ch_Doanhso.Series["Doanh Thu"].ChartType = SeriesChartType.Column;

            ch_Doanhso.ChartAreas[0].AxisX.Title = "Tháng";
            ch_Doanhso.ChartAreas[0].AxisY.Title = "Doanh Thu (VNĐ)";


        }
        void loadSoSanPham(string date)
        {
            ch_SanPham.Series.Clear();
            ch_SanPham.Series.Add("Số Lượng");
            ch_SanPham.Series["Số Lượng"].Color = System.Drawing.Color.Green;

            sql = "SELECT * FROM LoaiSanPhamCha";
            DataTable dt = config.ExecuteSelectQuery(sql);


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    sql = string.Format("select dbo.func_DemSLSanPhamCha({0},'{1}')", dr[0].ToString(), date);
                    Object result = config.ExecuteScalar(sql);
                    if (result == null) return;
                    int soLuong = int.Parse(result.ToString());
                    ch_SanPham.Series["Số Lượng"].Points.AddXY(dr[1].ToString(), soLuong);

                }
            }
            ch_SanPham.Series["Số Lượng"].ChartType = SeriesChartType.Column;
            ch_SanPham.ChartAreas[0].AxisX.Title = "Loại Sản Phẩm";
            ch_SanPham.ChartAreas[0].AxisY.Title = "Số lượng (Cái)";



        }

        private void dtp_soluong_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtp_soluong.Value;
            loadSoSanPham(selectedDate.ToString("yyyy/MM/dd"));
        }

        private void dtp_DoanhThu_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dtp_DoanhThu.Value;
            loadDoanhSo(selectedDate.ToString("yyyy/MM/dd"));
        }
        //private void InBaoCao()
        //{
        //    try
        //    {
        //        string downloadFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
        //        string filePath = Path.Combine(downloadFolderPath, "BaoCaoDoanhSo.pdf");

        //        PrintDocument printDocument = new PrintDocument();
        //        printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        //        printDocument.PrinterSettings.PrintToFile = true;
        //        printDocument.PrinterSettings.PrintFileName = filePath;
        //        printDocument.Print();

        //        if (File.Exists(filePath))
        //        {
        //            using (FileStream fs = new FileStream(filePath, FileMode.Create))
        //            {
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine($"Lỗi: {ex.Message}");
        //    }

        //}
    }
}
