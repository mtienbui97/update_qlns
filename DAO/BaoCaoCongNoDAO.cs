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
    public class BaoCaoCongNoDAO
    {

        #region 1. Inserting

        public static bool InsertBaoCaoCongNo(BaoCaoCongNoDTO BaoCaoCongNo)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaChiTietCongNo", BaoCaoCongNo.MaChiTietCongNo));
                parameters.Add(new MySqlParameter("p_NgayNhap", BaoCaoCongNo.Thang));
                parameters.Add(new MySqlParameter("p_MaKhachHang", BaoCaoCongNo.MaKhachHang));
                parameters.Add(new MySqlParameter("p_NoDau", BaoCaoCongNo.NoDau));
                parameters.Add(new MySqlParameter("p_NoCuoi", BaoCaoCongNo.NoCuoi));
                parameters.Add(new MySqlParameter("p_NoPhatSinh", BaoCaoCongNo.NoPhatSinh));
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Insert into BaoCaoCongNo values('{BaoCaoCongNo.MaBaoCaoCongNo}', '{BaoCaoCongNo.NgayNhap.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}')");
                var n = DataAccessHelper.ExecuteNonQuery("InsertBaoCaoCongNo", parameters);
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

        public static bool UpdateBaoCaoCongNo(BaoCaoCongNoDTO BaoCaoCongNo)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaChiTietCongNo", BaoCaoCongNo.MaChiTietCongNo));
                parameters.Add(new MySqlParameter("p_Thang", BaoCaoCongNo.Thang));
                parameters.Add(new MySqlParameter("p_MaKhachHang", BaoCaoCongNo.MaKhachHang));
                parameters.Add(new MySqlParameter("p_NoDau", BaoCaoCongNo.NoDau));
                parameters.Add(new MySqlParameter("p_NoCuoi", BaoCaoCongNo.NoCuoi));
                parameters.Add(new MySqlParameter("p_NoPhatSinh", BaoCaoCongNo.NoPhatSinh));
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Update BaoCaoCongNo Set NgayNhap = '{BaoCaoCongNo.NgayNhap.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)}' where MaBaoCaoCongNo = '{BaoCaoCongNo.MaBaoCaoCongNo}'");
                var n = DataAccessHelper.ExecuteNonQuery("UpdateBaoCaoCongNo", parameters);
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

        public static List<BaoCaoCongNoDTO> SelectBaoCaoCongNoAll()
        {
            var list = new List<BaoCaoCongNoDTO>();
            try
            {

                var dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoCongNoAll");
                //    var dt = DataAccessHelper.ExecuteQuery(
                //        "Select MaBaoCaoCongNo, NgayNhap From BaoCaoCongNo");
                list.AddRange(from DataRow dr in dt.Rows
                              select new BaoCaoCongNoDTO
                              {
                                  MaChiTietCongNo = dr["MaChiTietCongNo"].ToString(),
                                  Thang = DateTime.Parse(dr["Thang"].ToString()),
                                  MaKhachHang = dr["MaKhachHang"].ToString(),
                                  NoCuoi = decimal.Parse(dr["NoCuoi"].ToString()),
                                  NoDau = decimal.Parse(dr["NoDau"].ToString()),
                                  NoPhatSinh = decimal.Parse(dr["NoPhatSinh"].ToString())
                              });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        public static BaoCaoCongNoDTO SelectBaoCaoCongNoByMaBaoCaoCongNo(string maChiTietCongNo)
        {
            var BaoCaoCongNo = new BaoCaoCongNoDTO();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaChiTietCongNo", maChiTietCongNo));
                var dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoCongNoByMaBaoCaoCongNo", parameters);
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaBaoCaoCongNo, NgayNhap From BaoCaoCongNo Where MaBaoCaoCongNo = '{maBaoCaoCongNo}'");
                var dr = dt.Rows[0];
                BaoCaoCongNo.MaChiTietCongNo = dr["MaChiTietCongNo"].ToString();
                BaoCaoCongNo.Thang = DateTime.Parse(dr["Thang"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return BaoCaoCongNo;
        }

        public static BaoCaoCongNoDTO SelectBaoCaoCongNoThangGanNhatByMaKhachHang(string maKhachHang)
        {
            var baocaocongno = new BaoCaoCongNoDTO();
            try
            {

                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaKhachHang", maKhachHang));
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaBaoCaoCongNo From BaoCaoCongNo where MaBaoCaoCongNo = '{maBaoCaoCongNo}'");
                var dt = DataAccessHelper.ExecuteQuery("SelectBaoCaoCongNoThangGanNhatByMaKhachHang", parameters);
                var dr = dt.Rows[0];
                baocaocongno.MaChiTietCongNo = dr["MaChiTietCongNo"].ToString();
                baocaocongno.Thang = DateTime.Parse(dr["Thang"].ToString());
                baocaocongno.MaKhachHang = dr["MaKhachHang"].ToString();
                baocaocongno.NoCuoi = decimal.Parse(dr["NoCuoi"].ToString());
                baocaocongno.NoDau = decimal.Parse(dr["NoDau"].ToString());
                baocaocongno.NoPhatSinh = decimal.Parse(dr["NoPhatSinh"].ToString());

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return baocaocongno;
        }

        public static bool CheckBaoCaoCongNoByMaKhachHangvaThang(string maKhachHang, DateTime thang)
        {
            var result = false;
            try
            {

                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaKhachHang", maKhachHang));
                parameters.Add(new MySqlParameter("p_Thang", thang));
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaBaoCaoCongNo From BaoCaoCongNo where MaBaoCaoCongNo = '{maBaoCaoCongNo}'");
                var dt = DataAccessHelper.ExecuteQuery("CheckBaoCaoCongNoByMaKhachHangvaThang", parameters);
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

        public static string GenerateNewMaBaoCaoCongNo()
        {
            string newMaBaoCaoCongNo = "";
            try
            {

                var dt = DataAccessHelper.ExecuteQuery("GenerateNewMaBaoCaoCongNo");
                //var dt = DataAccessHelper.ExecuteQuery(
                //    "Select MAX(CAST(REPLACE(REPLACE(MaBaoCaoCongNo , 'PHNH', ''), '', '') as int)) + 1 as NewMaBaoCaoCongNo from BaoCaoCongNo");
                int temp = int.Parse(dt.Rows[0]["NewMaBaoCaoCongNo"].ToString());
                newMaBaoCaoCongNo = $"BCCN{temp:0000}";

                return newMaBaoCaoCongNo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
