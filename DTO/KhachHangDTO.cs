using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        #region Properties

        public string MaKhachHang
        {
            get;
            set;
        }

        public string HoTenKhachHang
        {
            get;
            set;
        }

        public string DiaChi
        {
            get;
            set;
        }

        public string SoDienThoai
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public decimal SoTienNo
        {
            get;
            set;
        }

        public bool TinhTrang
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public KhachHangDTO()
        {
            MaKhachHang = "";
            HoTenKhachHang = "";
            DiaChi = "";
            SoDienThoai = "";
            Email = "";
            SoTienNo = 0;
            TinhTrang = true;
        }
        #endregion
    }
}
