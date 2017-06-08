using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        #region Properties 
        public string MaChiTietHoaDon
        {
            get;
            set;
        }

        public string MaSach
        {
            get;
            set;    
        }

        public string MaHoaDon
        {
            get;
            set;
        }

        public int SoLuongBan
        {
            get;
            set;
        }

        public decimal DonGiaBan
        {
            get;
            set;
        }

        public decimal ThanhTien
        {
            get;
            set;
        }

        #endregion

        #region Constructor
        public ChiTietHoaDonDTO ()
        {
            MaChiTietHoaDon = "";
            MaHoaDon = "";
            MaSach = "";
            SoLuongBan = 0;
            DonGiaBan = 0;
            ThanhTien = 0;
        }
        #endregion
    }
}
