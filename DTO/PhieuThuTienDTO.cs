using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThuTienDTO
    {
        #region Properties

        public string MaPhieuThu
        {
            get;
            set;
        }

        public DateTime NgayThu
        {
            get;
            set;
        }

        public string MaKhachHang
        {
            get;
            set;
        }

        public decimal SoTienThu
        {
            get;
            set;
        }

       
        #endregion

        #region Constructor

        public PhieuThuTienDTO()
        {
            MaPhieuThu = "";
            MaKhachHang = "";
            NgayThu = DateTime.Now;
            SoTienThu = 0;
        }
        #endregion
    }
}
