using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class BaoCaoCongNoBUS
    {
        #region 1. Inserting
        public static bool InsertBaoCaoCongNo(BaoCaoCongNoDTO baocaocongno)
        {
            return BaoCaoCongNoDAO.InsertBaoCaoCongNo(baocaocongno);
        }

        public static bool UpdateBaoCaoCongNo(BaoCaoCongNoDTO baocaocongno)
        {
            return BaoCaoCongNoDAO.UpdateBaoCaoCongNo(baocaocongno);
        }

        //public static BaoCaoCongNoDTO SelectBaoCaoCongNoByMaKhachHangvaThang(string maKhachHang, DateTime thang)
        //{
        //    return BaoCaoCongNoDAO.SelectBaoCaoCongNoByMaKhachHangvaThangHienTai(maKhachHang, thang);
        //}

        public static BaoCaoCongNoDTO SelectBaoCaoCongNoThangGanNhatByMaKhachHang(string maKhachHang)
        {
           
           return BaoCaoCongNoDAO.SelectBaoCaoCongNoThangGanNhatByMaKhachHang(maKhachHang);
        }


        public static bool CheckBaoCaoCongNoByMaKhachHangvaThang(string maKhachHang, DateTime thang)
        {
            return BaoCaoCongNoDAO.CheckBaoCaoCongNoByMaKhachHangvaThang(maKhachHang, thang);
        }

        public static string GenerateNewMaBaoCaoCongNo()
        {
            return BaoCaoCongNoDAO.GenerateNewMaBaoCaoCongNo();
        } 

        #endregion
    }
}
