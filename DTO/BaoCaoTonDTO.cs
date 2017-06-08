using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoTonDTO
    {
        #region Properties

        public string MaChiTietTon
        {
            get;
            set;
        }

        public DateTime Thang
        {
            get;
            set;
        }

        public string MaSach
        {
            get;
            set;
        }

        public decimal TonDau
        {
            get;
            set;
        }

        public decimal TonPhatSinh
        {
            get;
            set;
        }

        public decimal TonCuoi
        {
            get;
            set;
        }



        #endregion

        #region Constructor

        public BaoCaoTonDTO()
        {
            MaChiTietTon = "";
            MaSach = "";
            Thang = DateTime.Now;
            TonDau = 0;
            TonCuoi = 0;
            TonPhatSinh = 0;
        }
        #endregion
    }
}
