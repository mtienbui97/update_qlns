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
    public class BaoCaoTonDAO
    {

        #region 1. Inserting

        public static bool InsertBaoCaoTon(BaoCaoTonDTO BaoCaoTon)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaChiTietTon", BaoCaoTon.MaChiTietTon));
                parameters.Add(new MySqlParameter("p_Thang", BaoCaoTon.Thang));
                parameters.Add(new MySqlParameter("p_MaSach", BaoCaoTon.MaSach));
                parameters.Add(new MySqlParameter("p_TonDau", BaoCaoTon.TonDau));
                parameters.Add(new MySqlParameter("p_TonCuoi", BaoCaoTon.TonCuoi));
                parameters.Add(new MySqlParameter("p_TonPhatSinh", BaoCaoTon.TonPhatSinh));
                //var n = DataAccessHelper.ExecuteTonnQuery(
                //    $"Insert into BaoCaoTon values('{BaoCaoTon.MaBaoCaoTon}', '{BaoCaoTon.Thang.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}')");
                var n = DataAccessHelper.ExecuteNonQuery("InsertBaoCaoTon", parameters);
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

        public static bool UpdateBaoCaoTon(BaoCaoTonDTO BaoCaoTon)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaChiTietTon", BaoCaoTon.MaChiTietTon));
                parameters.Add(new MySqlParameter("p_Thang", BaoCaoTon.Thang));
                parameters.Add(new MySqlParameter("p_MaSach", BaoCaoTon.MaSach));
                parameters.Add(new MySqlParameter("p_TonDau", BaoCaoTon.TonDau));
                parameters.Add(new MySqlParameter("p_TonCuoi", BaoCaoTon.TonCuoi));
                parameters.Add(new MySqlParameter("p_TonPhatSinh", BaoCaoTon.TonPhatSinh));
                //var n = DataAccessHelper.ExecuteTonnQuery(
                //    $"Update BaoCaoTon Set Thang = '{BaoCaoTon.Thang.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}' where MaBaoCaoTon = '{BaoCaoTon.MaBaoCaoTon}'");
                var n = DataAccessHelper.ExecuteNonQuery("UpdateBaoCaoTon", parameters);
                if (n == 1)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }

        #endregion

        public static List<BaoCaoTonDTO> SelectBaoCaoTonAll()
        {
            var list = new List<BaoCaoTonDTO>();
            try
            {

                var dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoTonAll");
                //    var dt = DataAccessHelper.ExecuteQuery(
                //        "Select MaBaoCaoTon, Thang From BaoCaoTon");
                list.AddRange(from DataRow dr in dt.Rows
                              select new BaoCaoTonDTO
                              {
                                  MaChiTietTon = dr["MaChiTietTon"].ToString(),
                                  Thang = DateTime.Parse(dr["Thang"].ToString()),
                                  MaSach = dr["MaSach"].ToString(),
                                  TonCuoi = decimal.Parse(dr["TonCuoi"].ToString()),
                                  TonDau = decimal.Parse(dr["TonDau"].ToString()),
                                  TonPhatSinh = decimal.Parse(dr["TonPhatSinh"].ToString())
                              });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        public static BaoCaoTonDTO SelectBaoCaoTonByMaBaoCaoTon(string maChiTietTon)
        {
            var BaoCaoTon = new BaoCaoTonDTO();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaChiTietTon", maChiTietTon));
                var dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoTonByMaBaoCaoTon", parameters);
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaBaoCaoTon, Thang From BaoCaoTon Where MaBaoCaoTon = '{maBaoCaoTon}'");
                var dr = dt.Rows[0];
                BaoCaoTon.MaChiTietTon = dr["MaChiTietTon"].ToString();
                BaoCaoTon.Thang = DateTime.Parse(dr["Thang"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return BaoCaoTon;
        }

        public static BaoCaoTonDTO SelectBaoCaoTonThangGanNhatByMaSach(string MaSach)
        {
            var baocaoTon = new BaoCaoTonDTO();
            try
            {

                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaSach", MaSach));
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaBaoCaoTon From BaoCaoTon where MaBaoCaoTon = '{maBaoCaoTon}'");
                var dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoTonThangGanNhatByMaSach", parameters);
                var dr = dt.Rows[0];
                baocaoTon.MaChiTietTon = dr["MaChiTietTon"].ToString();
                baocaoTon.Thang = DateTime.Parse(dr["Thang"].ToString());
                baocaoTon.MaSach = dr["MaSach"].ToString();
                baocaoTon.TonCuoi = decimal.Parse(dr["TonCuoi"].ToString());
                baocaoTon.TonDau = decimal.Parse(dr["TonDau"].ToString());
                baocaoTon.TonPhatSinh = decimal.Parse(dr["TonPhatSinh"].ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return baocaoTon;
        }

        public static bool CheckBaoCaoTonByMaSachvaThang(string MaSach, DateTime thang)
        {
            var result = false;
            try
            {

                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaSach", MaSach));
                parameters.Add(new MySqlParameter("p_Thang", thang));
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaBaoCaoTon From BaoCaoTon where MaBaoCaoTon = '{maBaoCaoTon}'");
                var dt = DataAccessHelper.ExecuteQuery("CheckBaoCaoTonByMaSachvaThang", parameters);
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

        public static string GenerateNewMaBaoCaoTon()
        {
            string newMaBaoCaoTon = "";
            try
            {

                var dt = DataAccessHelper.ExecuteQuery("GenerateNewMaBaoCaoTon");
                //var dt = DataAccessHelper.ExecuteQuery(
                //    "Select MAX(CAST(REPLACE(REPLACE(MaBaoCaoTon , 'PHNH', ''), '', '') as int)) + 1 as NewMaBaoCaoTon from BaoCaoTon");
                int temp = int.Parse(dt.Rows[0]["NewMaBaoCaoTon"].ToString());
                newMaBaoCaoTon = $"BCTO{temp:0000}";

                return newMaBaoCaoTon;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
