using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShopApp.Model
{
    public class HoaDon
    {
        public long IdHoaDon { get; set; }
        public long IdNhanVien { get; set; }
        public int IdChiNhanh { get; set; }
        public string SoDienThoai { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public DateTime NgayXuatHD { get; set; }
    }
}
