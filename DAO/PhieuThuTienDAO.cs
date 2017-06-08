using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using DTO;

namespace DAO
{
    public class PhieuThuTienDAO
    {
        #region 1. Inserting

        public static bool InsertPhieuThu(PhieuThuTienDTO phieuThu)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaPhieuThu", phieuThu.MaPhieuThu));
                parameters.Add(new MySqlParameter("p_NgayThuTien", phieuThu.NgayThu));
                parameters.Add(new MySqlParameter("p_MaKhachHang", phieuThu.MaKhachHang));
                parameters.Add(new MySqlParameter("p_SoTienThu", phieuThu.SoTienThu));

                var n = DataAccessHelper.ExecuteNonQuery("InsertPhieuThu", parameters);
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Insert into phieuThu values('{phieuThu.MaphieuThu}', '{phieuThu.NgayNhap.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}')");
              
                if (n == 1)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static string GenerateNewMaPhieuThu()
        {
            string newMaPhieuThu = "";
            try
            {

                var dt = DataAccessHelper.ExecuteQuery("GenerateNewMaPhieuThu");
                //var dt = DataAccessHelper.ExecuteQuery(
                //    "Select MAX(CAST(REPLACE(REPLACE(MaPhieuThu , 'PHNH', ''), '', '') as int)) + 1 as NewMaPhieuThu from PhieuThu");
                int temp = int.Parse(dt.Rows[0]["NewMaPhieuThu"].ToString());
                newMaPhieuThu = $"PHTH{temp:0000}";

                return newMaPhieuThu;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion
    }
}
