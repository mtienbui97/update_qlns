using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoCongNoDTO
    {
        #region Properties

        public string MaChiTietCongNo
        {
            get;
            set;
        }

        public DateTime Thang
        {
            get;
            set;
        }

        public string MaKhachHang
        {
            get;
            set;
        }

        public decimal NoDau
        {
            get;
            set;
        }

        public decimal NoPhatSinh 
        {
            get;
            set;
        }

        public decimal NoCuoi
        {
            get;
            set;
        }



        #endregion

        #region Constructor

        public BaoCaoCongNoDTO()
        {
            MaChiTietCongNo = "";
            MaKhachHang = "";
            Thang = DateTime.Now;
            NoDau = 0;
            NoCuoi = 0;
            NoPhatSinh = 0;
        }
        #endregion
    }
}
