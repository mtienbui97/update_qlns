using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

using DAO;

namespace BUS
{
    public class ThamSoBUS
    {
        #region 4. Updating

        public static bool UpdateSoLuongNhapItNhat(int soLuongNhapItNhat)
        {
            return ThamSoDAO.UpdateSoLuongNhapItNhat ( soLuongNhapItNhat );
        }

        public static bool UpdateSoLuongTonToiDaTruocNhap(int soLuongTonToiDaTruocNhap)
        {
            return ThamSoDAO.UpdateSoLuongTonToiDaTruocNhap ( soLuongTonToiDaTruocNhap );
        }

        public static bool UpdateThamSo (ThamSoDTO thamso)
        {
            return ThamSoDAO.UpdateThamSo(thamso);
        }

        #endregion

        #region 4. Retrieving

        public static int SelectSoLuongNhapItNhat()
        {
            return ThamSoDAO.SelectThamSoAll ( ).SoLuongNhapItNhat;
        }

        public static int SelectSoLuongTonToiDaTruocNhap()
        {
            return ThamSoDAO.SelectThamSoAll().SoLuongTonToiDaTruocNhap;
        }

        public static bool CheckApDungQuiDinh4()
        {
            var thamso = ThamSoDAO.SelectThamSoAll();
            return thamso.SuDungQuiDinh4;
        }
        public static ThamSoDTO SelectThamSoAll()
        {
            return ThamSoDAO.SelectThamSoAll();
        }

        
            

        #endregion
    }
}
