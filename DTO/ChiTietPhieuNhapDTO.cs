using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        #region Properties

        public string MaChiTietPhieuNhap
        {
            get;
            set;
        }

        public string MaPhieuNhap
        {
            get;
            set;
        }

        public string MaSach
        {
            get;
            set;
        }

        public int SoLuongNhap
        {
            get;
            set;
        }

        #endregion

        #region Constructor

        public ChiTietPhieuNhapDTO ( )
        {
            MaChiTietPhieuNhap = "";
            MaPhieuNhap = "";
            MaSach = "";
            SoLuongNhap = 0;
        }

        #endregion
    }
}
