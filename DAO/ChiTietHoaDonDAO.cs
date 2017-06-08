using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using DTO;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        #region 1. Inserting

        public static bool InsertChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDon)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaChiTietHoaDon", chiTietHoaDon.MaChiTietHoaDon));
                parameters.Add(new MySqlParameter("p_MaHoaDon", chiTietHoaDon.MaHoaDon));
                parameters.Add(new MySqlParameter("p_MaSach", chiTietHoaDon.MaSach));
                parameters.Add(new MySqlParameter("p_SoLuongBan", chiTietHoaDon.SoLuongBan));
                parameters.Add(new MySqlParameter("p_DonGiaBan", chiTietHoaDon.DonGiaBan));
                parameters.Add(new MySqlParameter("p_ThanhTien", chiTietHoaDon.ThanhTien));
                //    var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Insert into ChiTietPhieuNhap values('{chiTietHoaDon.MaChiTietHoaDon}', '{chiTietHoaDon.MaHoaDon}', '{chiTietHoaDon.SoLuongNhap}', '{chiTietPhieuNhap.MaSach}')");
                var n = DataAccessHelper.ExecuteNonQuery("InsertChiTietHoaDon", parameters);
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

        public static bool UpdateChiTietHoaDon(ChiTietHoaDonDTO chiTietHoaDon)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaChiTietHoaDon", chiTietHoaDon.MaChiTietHoaDon));
                parameters.Add(new MySqlParameter("p_MaHoaDon", chiTietHoaDon.MaHoaDon));
                parameters.Add(new MySqlParameter("p_MaSach", chiTietHoaDon.MaSach));
                parameters.Add(new MySqlParameter("p_SoLuongBan", chiTietHoaDon.SoLuongBan));
                parameters.Add(new MySqlParameter("p_DonGiaBan", chiTietHoaDon.DonGiaBan));
                parameters.Add(new MySqlParameter("p_ThanhTien", chiTietHoaDon.ThanhTien));

                var n = DataAccessHelper.ExecuteNonQuery("UpdateChiTietHoaDon", parameters);
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Update ChiTietPhieuNhap Set MaHoaDon = '{chiTietPhieuNhap.MaHoaDon}', SoLuongNhap = '{chiTietPhieuNhap.SoLuongNhap}', MaSach = '{chiTietPhieuNhap.MaSach}' where MaChiTietHoaDon = '{chiTietPhieuNhap.MaChiTietHoaDon}'");
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

        public static bool DeleteChiTietHoaDonByMaChiTietHoaDon(string MaChiTietHoaDon)
        {
            var result = false;
            try
            {
                var n = DataAccessHelper.ExecuteNonQuery(
                    $"Delete From ChiTietPhieuNhap Where MaChiTietHoaDon = '{MaChiTietHoaDon}'");
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

        public static List<ChiTietHoaDonDTO> SelectChiTietHoaDonAll()
        {
            var list = new List<ChiTietHoaDonDTO>();
            try
            {
                // var dt = DataAccessHelper.ExecuteQuery(
                //"Select MaChiTietHoaDon, MaHoaDon, SoLuongNhap, MaSach From ChiTietPhieuNhap");
                var dt = DataAccessHelper.ExecuteQuery("SelectChiTietPhieuNhapAll");
                list.AddRange(from System.Data.DataRow dr in dt.Rows
                              select new ChiTietHoaDonDTO
                              {
                                  MaChiTietHoaDon = dr["MaChiTietHoaDon"].ToString(),
                                  MaHoaDon = dr["MaHoaDon"].ToString(),
                                  SoLuongBan = int.Parse(dr["SoLuongNhap"].ToString()),
                                  MaSach = dr["MaSach"].ToString(),
                                  DonGiaBan = decimal.Parse(dr["DonGiaBan"].ToString()),
                                  ThanhTien = decimal.Parse(dr["ThanhTien"].ToString())
                              });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        public static ChiTietHoaDonDTO SelectChiTietHoaDonByMaChiTietHoaDon(string MaChiTietHoaDon)
        {
            var ChiTietHoaDon = new ChiTietHoaDonDTO();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaChiTietHoaDon", MaChiTietHoaDon));
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaChiTietHoaDon, MaHoaDon, SoLuongNhap, MaSach From ChiTietPhieuNhap Where MaChiTietHoaDon = '{MaChiTietHoaDon}'");
                var dt = DataAccessHelper.ExecuteQuery("SelectChiTietHoaDonByMaChiTietHoaDon", parameters);
                var dr = dt.Rows[0];
                ChiTietHoaDon.MaChiTietHoaDon = dr["MaChiTietHoaDon"].ToString();
                ChiTietHoaDon.MaHoaDon = dr["MaHoaDon"].ToString();
                ChiTietHoaDon.SoLuongBan = int.Parse(dr["SoLuongNhap"].ToString());
                ChiTietHoaDon.MaSach = dr["MaSach"].ToString();
                ChiTietHoaDon.DonGiaBan = decimal.Parse(dr["DonGiaBan"].ToString());
                ChiTietHoaDon.ThanhTien = decimal.Parse(dr["DonGiaBan"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ChiTietHoaDon;
        }

        public static bool CheckChiTietPhieuNhapByMaChiTietHoaDon(string MaChiTietHoaDon)
        {
            var result = false;
            try
            {
                var dt = DataAccessHelper.ExecuteQuery(
                    $"Select MaChiTietHoaDon From ChiTietPhieuNhap where MaChiTietHoaDon = '{MaChiTietHoaDon}'");
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

        public static string GenerateNewMaChiTietHoaDon()
        {
            var newMaChiTietHoaDon = 0;
            try
            {
                var dt = DataAccessHelper.ExecuteQuery(
                    "Select MAX(CAST(REPLACE(REPLACE(MaChiTietHoaDon , 'CTHD', ''), '', '') as int)) + 1 as NewMaChiTietHoaDon from ChiTietHoaDon");
                newMaChiTietHoaDon = dt.Rows[0]["NewMaChiTietHoaDon"].ToString() == "" ?
                    1 :
                    int.Parse(dt.Rows[0]["NewMaChiTietHoaDon"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return $"CTHD{newMaChiTietHoaDon:0000}";
        }

        #endregion

    }
}
