using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShopApp.Model
{
    public class NguoiDung
    {
        public long IdNguoiDung { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int IdVaiTro { get; set; }
        public bool TonTai { get; set; }
        public bool Cam { get; set; }
    }
}
