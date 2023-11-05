using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShopApp.Model
{
    public class SanPham
    {
        public long IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int IdLoaiSP { get; set; }
        public string AnhSP { get; set; }
        public string AnhSPChiTiet1 { get; set; }
        public string AnhSPChiTiet2 { get; set; }
        public long GiaBan { get; set; }
        public int GiamGia { get; set; }
        public int SoLuongDanhGia { get; set; }
        public string NoiDungSanPham { get; set; }
        public string DanhGiaSanPham { get; set; }
        public string ThanhToanVanChuyen { get; set; }
        public bool TonTai { get; set; }
    }
}
