using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShopApp.Model
{
    public class ChiTietDonHang
    {
        public long IdDonHang { get; set; }
        public long IdSanPham { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
    }
}
