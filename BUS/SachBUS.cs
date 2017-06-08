using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;

using DTO;

namespace BUS
{
    public class SachBUS
    {
        #region 1. Inserting
        public static bool InsertSach(List<SachDTO> listSach)
        {
            foreach (SachDTO sach in listSach)
            {
                sach.MaSach = SachDAO.GenerateNewMaSach();
                sach.SoLuongTon = 0;
                if(!SachDAO.InsertSach(sach))
                {
                    return false;
                }
            }

            return true;
        }
        #endregion
       
        #region 4. Retrieving

        public static List<SachDTO> SelectSachAll()
        {
            return SachDAO.SelectSachAll();
        }
      
        public static SachDTO SelectSachByMaSach(string maSach)
        {
            return SachDAO.SelectSachByMaSach(maSach);
        }

        #endregion

        #region 5.Finding
        public static List<SachDTO> FindSachByTenSach(string tensach)
        {
            List<SachDTO> listSach = new List<SachDTO>();
            List<SachDTO> listResult = new List<SachDTO>();

            foreach(SachDTO sach in listSach)
            {
                //if(sach.TenSach )
            }

            return listResult;
        }
        #endregion
    }
}
