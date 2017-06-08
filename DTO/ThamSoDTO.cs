using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThamSoDTO
    {
        #region Properties

        public int SoLuongNhapItNhat
        {
            get;
            set;
        }

        public int SoLuongTonToiDaTruocNhap
        {
            get;
            set;
        }

        public int SoLuongTonToiThieuSauBan
        {
            get;
            set;
        }

        public int SoTienNoToiDa
        {
            get;
            set;
        }

        public bool SuDungQuiDinh4
        {
            get;
            set;
        }
        #endregion

        #region Constructor

        public ThamSoDTO ( )
        {
            SoLuongNhapItNhat = 0;
            SoLuongTonToiDaTruocNhap = 0;
            SoLuongTonToiThieuSauBan = 0;
            SoTienNoToiDa = 0;
            SuDungQuiDinh4 = true;
        }

        #endregion
    }
}
