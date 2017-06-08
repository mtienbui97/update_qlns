using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class KhachHangBUS
    {
        #region 1. Inserting
        public static bool InsertKhachHang(List<KhachHangDTO> listKhachHang)
        {
            foreach (KhachHangDTO khachhang in listKhachHang)
            {
                khachhang.MaKhachHang = KhachHangDAO.GenerateNewMaKhachHang();
                khachhang.SoTienNo = 0;
                if(!KhachHangDAO.InsertKhachHang(khachhang))
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        #region 4. Retrieving
        public static KhachHangDTO SelectKhachHangByMaKhachHang(string maKhachHang)
        {
            return KhachHangDAO.SelectKhachHangByMaKhachHang(maKhachHang);
        }

        
        public static bool CheckKhachHangByMaKhachHang(string maKhachHang)
        {
            return KhachHangDAO.CheckKhachHangByMaKhachHang(maKhachHang);
        }
        #endregion

        public static string GenerateNewMaKhachHang()
        {
            return KhachHangDAO.GenerateNewMaKhachHang();
        }
    }
}
