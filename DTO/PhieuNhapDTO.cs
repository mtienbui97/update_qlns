using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        #region Properties

        public string MaPhieuNhap
        {
            get;
            set;
        }

        public DateTime NgayNhap
        {
            get;
            set;
        }

        #endregion

        #region Constructor

        public PhieuNhapDTO ( )
        {
            MaPhieuNhap = "";
            NgayNhap = new DateTime ( );
        }

        #endregion

       
    }
}