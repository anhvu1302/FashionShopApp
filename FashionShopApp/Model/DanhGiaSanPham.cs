using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShopApp.Model
{
    public class DanhGiaSanPham
    {
        public long IdDanhGia { get; set; }
        public long IdSanPham { get; set; }
        public long IdKhachHang { get; set; }
        public int DiemDanhGia { get; set; }
        public string NhanXet { get; set; }
        public DateTime ThoiGianDanhGia { get; set; }
    }
}
