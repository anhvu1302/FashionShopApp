using CrystalDecisions.Shared;
using FashionShopApp.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FashionShopApp.GUI
{
    public partial class frmReportHoaDon : Form
    {
        SQLConfig config = new SQLConfig(NguoiDungHienTai.CurentUser.nguoiDung.TenTaiKhoan, NguoiDungHienTai.CurentUser.nguoiDung.MatKhau);
        string sql;
        public frmReportHoaDon()
        {
            InitializeComponent();
        }

        private void frmReportHoaDon_Load(object sender, EventArgs e)
        {
            rptHoaDon rp = new rptHoaDon();
            rp.SetDatabaseLogon(NguoiDungHienTai.CurentUser.nguoiDung.TenTaiKhoan, NguoiDungHienTai.CurentUser.nguoiDung.MatKhau, "DESKTOP-1LB6J34\\SQLEXPRESS", "FashionShopManagement");
            //rp.SetDatabaseLogon("sa", "123", "DESKTOP-1LB6J34\\SQLEXPRESS", "FashionShopManagement");
            ParameterValues currentUserPar = new ParameterValues();
            ParameterDiscreteValue currentUser = new ParameterDiscreteValue();

            ParameterValues currentDatePar = new ParameterValues();
            ParameterDiscreteValue currentDate = new ParameterDiscreteValue();

            currentUser.Value = TenNguoiDungHienTai();
            currentUserPar.Add(currentUser);

            currentDate.Value = DateTime.Now.Date;
            currentDatePar.Add(currentDate);
            try
            {
                rp.SetParameterValue("CurrentUser", currentUserPar);
                rp.SetParameterValue("CurrentDate", currentDatePar);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Lỗi SQL: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
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
    }
}
