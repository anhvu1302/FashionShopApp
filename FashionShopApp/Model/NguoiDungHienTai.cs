using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionShopApp.Model
{
    public class NguoiDungHienTai
    {
        private static NguoiDungHienTai curentUser;
        public NguoiDung nguoiDung { get; set; }
        public string tenVaiTro { get; set; }
        private NguoiDungHienTai()
        {
            nguoiDung = new NguoiDung(); // Khởi tạo đối tượng của bạn ở đây
        }

        public static NguoiDungHienTai CurentUser
        {
            get
            {
                if (curentUser == null)
                {
                    curentUser = new NguoiDungHienTai();
                }
                return curentUser;
            }
        }
    }
}
