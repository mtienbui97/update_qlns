using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SachDTO
    {
        #region Properties

        public string MaSach
        {
            get;
            set;
        }

        public string TenSach
        {
            get;
            set;
        }

        public string TheLoai
        {
            get;
            set;
        }

        public string TacGia
        {
            get;
            set;
        }

        public float DonGia
        {
            get;
            set;
        }

        public int SoLuongTon
        {
            get;
            set;
        }

        public int TinhTrang
        {
            get;
            set;
        }

        #endregion

        #region Constructor

        public SachDTO ( )
        {
            MaSach = "";
            TenSach = "";
            TacGia = "";
            SoLuongTon = 0;
            DonGia = 0;
            TheLoai = "";
            TinhTrang = 0;
        }

        #endregion
    }
}
