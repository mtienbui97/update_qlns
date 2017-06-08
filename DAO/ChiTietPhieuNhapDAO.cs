using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

using DTO;

namespace DAO
{
    public class ChiTietPhieuNhapDAO
    {
        #region 1. Inserting

        public static bool InsertChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhap)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaChiTietHoaDon", chiTietPhieuNhap.MaChiTietPhieuNhap));
                parameters.Add(new MySqlParameter("p_MaPhieuNhap", chiTietPhieuNhap.MaPhieuNhap));
                parameters.Add(new MySqlParameter("p_MaSach", chiTietPhieuNhap.MaSach));
                parameters.Add(new MySqlParameter("p_SoLuongNhap", chiTietPhieuNhap.SoLuongNhap));
                var n = DataAccessHelper.ExecuteNonQuery("InsertChiTietPhieuNhap", parameters);
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Insert into ChiTietPhieuNhap values('{chiTietPhieuNhap.MaChiTietPhieuNhap}', '{chiTietPhieuNhap.MaPhieuNhap}', '{chiTietPhieuNhap.SoLuongNhap}', '{chiTietPhieuNhap.MaSach}')");
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

        public static bool UpdateChiTietPhieuNhap(ChiTietPhieuNhapDTO chiTietPhieuNhap)
        {
            var result = false;
            try
            {
                var n = DataAccessHelper.ExecuteNonQuery(
                    $"Update ChiTietPhieuNhap Set MaPhieuNhap = '{chiTietPhieuNhap.MaPhieuNhap}', SoLuongNhap = '{chiTietPhieuNhap.SoLuongNhap}', MaSach = '{chiTietPhieuNhap.MaSach}' where MaChiTietPhieuNhap = '{chiTietPhieuNhap.MaChiTietPhieuNhap}'");
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

        public static bool DeleteChiTietPhieuNhapByMaChiTietPhieuNhap(string maChiTietPhieuNhap)
        {
            var result = false;
            try
            {
                var n = DataAccessHelper.ExecuteNonQuery(
                    $"Delete From ChiTietPhieuNhap Where MaChiTietPhieuNhap = '{maChiTietPhieuNhap}'");
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

        public static List<ChiTietPhieuNhapDTO> SelectChiTietPhieuNhapAll()
        {
            var list = new List<ChiTietPhieuNhapDTO>();
            try
            {
                var dt = DataAccessHelper.ExecuteQuery(
                    "Select MaChiTietPhieuNhap, MaPhieuNhap, SoLuongNhap, MaSach From ChiTietPhieuNhap");
                list.AddRange(from DataRow dr in dt.Rows
                    select new ChiTietPhieuNhapDTO
                    {
                        MaChiTietPhieuNhap = dr["MaChiTietPhieuNhap"].ToString(),
                        MaPhieuNhap = dr["MaPhieuNhap"].ToString(),
                        SoLuongNhap = int.Parse (dr["SoLuongNhap"].ToString()),
                        MaSach = dr["MaSach"].ToString()
                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        public static ChiTietPhieuNhapDTO SelectChiTietPhieuNhapByMaChiTietPhieuNhap(string maChiTietPhieuNhap)
        {
            var ChiTietPhieuNhap = new ChiTietPhieuNhapDTO();
            try
            {
                var dt = DataAccessHelper.ExecuteQuery(
                    $"Select MaChiTietPhieuNhap, MaPhieuNhap, SoLuongNhap, MaSach From ChiTietPhieuNhap Where MaChiTietPhieuNhap = '{maChiTietPhieuNhap}'");
                var dr = dt.Rows[0];
                ChiTietPhieuNhap.MaChiTietPhieuNhap = dr["MaChiTietPhieuNhap"].ToString();
                ChiTietPhieuNhap.MaPhieuNhap = dr["MaPhieuNhap"].ToString();
                ChiTietPhieuNhap.SoLuongNhap = int.Parse(dr["SoLuongNhap"].ToString());
                ChiTietPhieuNhap.MaSach = dr["MaSach"].ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ChiTietPhieuNhap;
        }

        public static bool CheckChiTietPhieuNhapByMaChiTietPhieuNhap(string maChiTietPhieuNhap)
        {
            var result = false;
            try
            {
                var dt = DataAccessHelper.ExecuteQuery(
                    $"Select MaChiTietPhieuNhap From ChiTietPhieuNhap where MaChiTietPhieuNhap = '{maChiTietPhieuNhap}'");
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

        public static string GenerateNewMaChiTietPhieuNhap()
        {
            var newMaChiTietPhieuNhap = 0;
            try
            {
                var dt = DataAccessHelper.ExecuteQuery(
                    "Select MAX(CAST(REPLACE(REPLACE(MaChiTietPhieuNhap , 'CTPN', ''), '', '') as int)) + 1 as NewMaChiTietPhieuNhap from ChiTietPhieuNhap");
                newMaChiTietPhieuNhap = dt.Rows[0]["NewMaChiTietPhieuNhap"].ToString() == "" ?
                    1 :
                    int.Parse(dt.Rows[0]["NewMaChiTietPhieuNhap"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return $"CTPN{newMaChiTietPhieuNhap:0000}";
        }

        #endregion
    }
}
