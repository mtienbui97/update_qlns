using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        #region Properties
        public string MaHoaDon
        {
            get;
            set;
        }

        public string MaKhachHang
        {
            get;
            set;
        }

        public DateTime NgayLapHoaDon
        {
            get;
            set;
        }

        public int TongThanhTien
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public HoaDonDTO()
        {
            MaHoaDon = "";
            MaKhachHang = "";
            NgayLapHoaDon = DateTime.Now;
            TongThanhTien = 0;
        }
        #endregion
    }
}
