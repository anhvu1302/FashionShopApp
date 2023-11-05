using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShopApp.Model
{
    public class DonHang
    {
        public long IdDonHang { get; set; }
        public long IdKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public DateTime ThoiGianDatHang { get; set; }
        public DateTime ThoiGianGiaoHangDuKien { get; set; }
        public string TrangThaiDonHang { get; set; }
        public string TrangThaiThanhToan { get; set; }
    }

}
