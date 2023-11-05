using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShopApp.Model
{
    public class HoaDonNhapKho
    {
        public long IdHoaDonNhapKho { get; set; }
        public DateTime NgayNhap { get; set; }
        public long IdNhanVien { get; set; }
        public int IdChiNhanh { get; set; }
    }
}
