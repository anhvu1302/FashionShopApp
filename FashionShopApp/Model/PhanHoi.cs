using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShopApp.Model
{
    public class PhanHoi
    {
        public long IdPhanHoi { get; set; }
        public long IdKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string VanDe { get; set; }
        public string NoiDungVanDe { get; set; }
        public DateTime ThoiGianPhanHoi { get; set; }
    }
}
