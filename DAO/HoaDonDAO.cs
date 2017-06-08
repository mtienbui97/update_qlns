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
    public class HoaDonDAO
    {
        #region 1. Inserting

        public static bool InsertHoaDon(HoaDonDTO hoaDon)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaHoaDon", hoaDon.MaHoaDon));
                parameters.Add(new MySqlParameter("@NgayLapHoaDon", hoaDon.NgayLapHoaDon));
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Insert into hoaDon values('{hoaDon.MaHoaDon}', '{hoaDon.NgayLapHoaDon.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}')");
                var n = DataAccessHelper.ExecuteNonQuery("InsertHoaDon", parameters);
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

        public static bool UpdateHoaDon(HoaDonDTO hoaDon)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaHoaDon", hoaDon.MaHoaDon));
                parameters.Add(new MySqlParameter("p_NgayLapHoaDon", hoaDon.NgayLapHoaDon));
                parameters.Add(new MySqlParameter("p_MaKhachHang", hoaDon.MaKhachHang));
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Update hoaDon Set NgayLapHoaDon = '{hoaDon.NgayLapHoaDon.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}' where MaHoaDon = '{hoaDon.MaHoaDon}'");
                var n = DataAccessHelper.ExecuteNonQuery("UpdateHoaDon", parameters);
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

        public static bool DeletehoaDonByMaHoaDon(string MaHoaDon)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaHoaDon", MaHoaDon));
                //parameters.Add(new MySqlParameter("@NgayLapHoaDon", hoaDon.NgayLapHoaDon));
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Delete From hoaDon Where MaHoaDon = '{MaHoaDon}'");
                var n = DataAccessHelper.ExecuteNonQuery("DeleteHoaDonByMaHoaDon", parameters);
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

        public static List<HoaDonDTO> SelecthoaDonAll()
        {
            var list = new List<HoaDonDTO>();
            try
            {

                var dt = DataAccessHelper.ExecuteQuery("SelecthoaDonAll");
                //    var dt = DataAccessHelper.ExecuteQuery(
                //        "Select MaHoaDon, NgayLapHoaDon From hoaDon");
                list.AddRange(from DataRow dr in dt.Rows
                              select new HoaDonDTO
                              {
                                  MaHoaDon = dr["MaHoaDon"].ToString(),
                                  NgayLapHoaDon = DateTime.Parse(dr["NgayLapHoaDon"].ToString()),
                              });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        public static HoaDonDTO SelecthoaDonByMaHoaDon(string MaHoaDon)
        {
            var hoaDon = new HoaDonDTO();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaHoaDon", MaHoaDon));
                var dt = DataAccessHelper.ExecuteQuery("SelecthoaDonByMaHoaDon", parameters);
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaHoaDon, NgayLapHoaDon From hoaDon Where MaHoaDon = '{MaHoaDon}'");
                var dr = dt.Rows[0];
                hoaDon.MaHoaDon = dr["MaHoaDon"].ToString();
                hoaDon.NgayLapHoaDon = DateTime.Parse(dr["NgayLapHoaDon"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return hoaDon;
        }

        public static bool CheckhoaDonByMaHoaDon(string MaHoaDon)
        {
            var result = false;
            try
            {

                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("@MaHoaDon", MaHoaDon));
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaHoaDon From hoaDon where MaHoaDon = '{MaHoaDon}'");
                var dt = DataAccessHelper.ExecuteQuery("CheckhoaDonByMaHoaDon", parameters);
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

        public static string GenerateNewMaHoaDon()
        {
            string newMaHoaDon = "";
            try
            {
                var dt = DataAccessHelper.ExecuteQuery("GenerateNewMaHoaDon");
                //    "Select MAX(CAST(REPLACE(REPLACE(MaHoaDon , 'PHNH', ''), '', '') as int)) + 1 as NewMaHoaDon from hoaDon");
                //newMaHoaDon = dt.Rows[0]["NewMaHoaDon"].ToString() == "" ?
                //    1 :
                //    int.Parse(dt.Rows[0]["NewMaHoaDon"].ToString());
                int temp = int.Parse(dt.Rows[0]["NewMaHoaDon"].ToString());
                newMaHoaDon = $"HD{temp:0000}";
                return newMaHoaDon; ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
