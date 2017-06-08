using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BaoCaoTonBUS
    {
        #region 1. Inserting
        public static bool InsertBaoCaoTon(BaoCaoTonDTO baocaoTon)
        {
            return BaoCaoTonDAO.InsertBaoCaoTon(baocaoTon);
        }

        public static bool UpdateBaoCaoTon(BaoCaoTonDTO baocaoTon)
        {
            return BaoCaoTonDAO.UpdateBaoCaoTon(baocaoTon);
        }

        //public static BaoCaoTonDTO SelectBaoCaoTonByMaKhachHangvaThang(string maKhachHang, DateTime thang)
        //{
        //    return BaoCaoTonDAO.SelectBaoCaoTonByMaKhachHangvaThangHienTai(maKhachHang, thang);
        //}

        public static BaoCaoTonDTO SelectBaoCaoTonThangGanNhatByMaSach(string maSach)
        {

            return BaoCaoTonDAO.SelectBaoCaoTonThangGanNhatByMaSach(maSach);
        }


        public static bool CheckBaoCaoTonByMaKhachHangvaThang(string maSach, DateTime thang)
        {
            return BaoCaoTonDAO.CheckBaoCaoTonByMaSachvaThang(maSach,thang);
        }

        public static string GenerateNewMaBaoCaoTon()
        {
            return BaoCaoTonDAO.GenerateNewMaBaoCaoTon();
        }

        #endregion
    }
}
