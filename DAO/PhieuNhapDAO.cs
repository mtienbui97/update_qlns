using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

using DTO;

namespace DAO
{
    public class PhieuNhapDAO
    {
        #region 1. Inserting

        public static bool InsertPhieuNhap(PhieuNhapDTO phieuNhap)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaPhieuNhap", phieuNhap.MaPhieuNhap));
                parameters.Add(new MySqlParameter("@NgayNhap", phieuNhap.NgayNhap));
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Insert into PhieuNhap values('{phieuNhap.MaPhieuNhap}', '{phieuNhap.NgayNhap.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}')");
                var n = DataAccessHelper.ExecuteNonQuery("InsertPhieuNhap", parameters);
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

        #endregion

        #region 2. Updating

        public static bool UpdatePhieuNhap(PhieuNhapDTO phieuNhap)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaPhieuNhap", phieuNhap.MaPhieuNhap));
                parameters.Add(new MySqlParameter("@NgayNhap", phieuNhap.NgayNhap));
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Update PhieuNhap Set NgayNhap = '{phieuNhap.NgayNhap.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}' where MaPhieuNhap = '{phieuNhap.MaPhieuNhap}'");
                var n = DataAccessHelper.ExecuteNonQuery("UpdatePhieuNhap", parameters);
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

        #endregion

        #region 3. Deleting

        public static bool DeletePhieuNhapByMaPhieuNhap(string maPhieuNhap)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaPhieuNhap", maPhieuNhap));
                //parameters.Add(new MySqlParameter("@NgayNhap", phieuNhap.NgayNhap));
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Delete From PhieuNhap Where MaPhieuNhap = '{maPhieuNhap}'");
                var n = DataAccessHelper.ExecuteNonQuery("DeletePhieuNhapByMaPhieuNhap", parameters);
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

        #endregion

        #region 4. Retrieving

        public static List<PhieuNhapDTO> SelectPhieuNhapAll()
        {
            var list = new List<PhieuNhapDTO>();
            try
            {

                var dt = DataAccessHelper.ExecuteQuery("SelectPhieuNhapAll");
            //    var dt = DataAccessHelper.ExecuteQuery(
            //        "Select MaPhieuNhap, NgayNhap From PhieuNhap");
                list.AddRange(from DataRow dr in dt.Rows
                    select new PhieuNhapDTO
                    {
                        MaPhieuNhap = dr["MaPhieuNhap"].ToString(),
                        NgayNhap = DateTime.Parse ( dr["NgayNhap"].ToString())
                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        public static PhieuNhapDTO SelectPhieuNhapByMaPhieuNhap(string maPhieuNhap)
        {
            var phieuNhap = new PhieuNhapDTO();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaPhieuNhap", maPhieuNhap));
                var dt = DataAccessHelper.ExecuteQuery("SelectPhieuNhapByMaPhieuNhap", parameters);
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaPhieuNhap, NgayNhap From PhieuNhap Where MaPhieuNhap = '{maPhieuNhap}'");
                var dr = dt.Rows[0];
                phieuNhap.MaPhieuNhap = dr["MaPhieuNhap"].ToString();
                phieuNhap.NgayNhap = DateTime.Parse(dr["NgayNhap"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return phieuNhap;
        }

        public static bool CheckPhieuNhapByMaPhieuNhap(string maPhieuNhap)
        {
            var result = false;
            try
            {

                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaPhieuNhap", maPhieuNhap));
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaPhieuNhap From PhieuNhap where MaPhieuNhap = '{maPhieuNhap}'");
                var dt = DataAccessHelper.ExecuteQuery("CheckPhieuNhapByMaPhieuNhap", parameters);
                if (dt.Rows.Count == 1)
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

        public static string GenerateNewMaPhieuNhap()
        {
            string newMaPhieuNhap = "";
            try
            {
                
                var dt = DataAccessHelper.ExecuteQuery("GenerateNewMaPhieuNhap2");
                //var dt = DataAccessHelper.ExecuteQuery(
                //    "Select MAX(CAST(REPLACE(REPLACE(MaPhieuNhap , 'PHNH', ''), '', '') as int)) + 1 as NewMaPhieuNhap from PhieuNhap");
                int temp = int.Parse(dt.Rows[0]["NewMaPhieuNhap"].ToString());
                newMaPhieuNhap = $"PHNH{temp:0000}";

                return newMaPhieuNhap;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
