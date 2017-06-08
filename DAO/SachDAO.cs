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
    public class SachDAO
    {
        #region 1. Inserting

        public static bool InsertSach(SachDTO sach)
        {
            var result = false;
            try
            {
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Insert into Sach values('{sach.MaSach}', '{sach.TenSach}', '{sach.TheLoai}', '{sach.TacGia}', '{sach.DonGia}', '{sach.SoLuongTon}')");


                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaSach", sach.MaSach));
                parameters.Add(new MySqlParameter("p_Tensach", sach.TenSach));
                parameters.Add(new MySqlParameter("p_TheLoai", sach.TheLoai));
                parameters.Add(new MySqlParameter("p_TacGia", sach.TacGia));
                parameters.Add(new MySqlParameter("p_SoLuongTon", sach.SoLuongTon));
                parameters.Add(new MySqlParameter("p_DonGia", sach.DonGia));
                parameters.Add(new MySqlParameter("P_TinhTrang", sach.TinhTrang));
                var n = DataAccessHelper.ExecuteNonQuery("InsertSach", parameters);

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
        
        public static bool UpdateSach(SachDTO sach)
        {
            var result = false;
            try
            {

                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaSach", sach.MaSach));
                parameters.Add(new MySqlParameter("p_Tensach", sach.TenSach));
                parameters.Add(new MySqlParameter("p_TheLoai", sach.TheLoai));
                parameters.Add(new MySqlParameter("p_TacGia", sach.TacGia));
                parameters.Add(new MySqlParameter("p_SoLuongTon", sach.SoLuongTon));
                parameters.Add(new MySqlParameter("p_DonGia", sach.DonGia));
                parameters.Add(new MySqlParameter("P_TinhTrang", sach.TinhTrang));
                var n = DataAccessHelper.ExecuteNonQuery("UpdateSach", parameters);
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Update Sach Set TenSach = '{Sach.TenSach}', TheLoai = '{Sach.TheLoai}', TacGia = '{Sach.TacGia}', DonGia = '{Sach.DonGia}', SoLuongTon = '{Sach.SoLuongTon}' where MaSach = '{Sach.MaSach}'");
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

        public static bool DeleteSachByMaSach(string maSach)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaSach",maSach));
                var n = DataAccessHelper.ExecuteNonQuery("DeleteSachByMaSach", parameters);
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Delete From Sach Where MaSach = '{maSach}'");
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

        public static List<SachDTO> SelectSachAll()
        {
            var list = new List<SachDTO>();
            try
            {
                var dt = DataAccessHelper.ExecuteQuery("SelectSachAll");
                //var dt = DataAccessHelper.ExecuteQuery(
                //    "Select MaSach, TenSach, TheLoai, TacGia, DonGia, SoLuongTon From Sach");
                list.AddRange(from DataRow dr in dt.Rows
                              select new SachDTO
                              {
                                  MaSach = dr["MaSach"].ToString(),
                                  TenSach = dr["TenSach"].ToString(),
                                  TheLoai = dr["TheLoai"].ToString(),
                                  TacGia = dr["TacGia"].ToString(),
                                  DonGia = float.Parse(dr["DonGia"].ToString()),
                                  SoLuongTon = int.Parse(dr["SoLuongTon"].ToString()),
                                  TinhTrang = int.Parse(dr["TinhTrang"].ToString())
                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        public static SachDTO SelectSachByMaSach(string maSach)
        {
            var Sach = new SachDTO();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaSach", maSach));
                var dt = DataAccessHelper.ExecuteQuery("SelectSachByMaSach", parameters);
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaSach, TenSach, TheLoai, TacGia, DonGia, SoLuongTon From Sach Where MaSach = '{maSach}'");
                var dr = dt.Rows[0];
                Sach.MaSach = dr["MaSach"].ToString();
                Sach.TenSach = dr["TenSach"].ToString();
                Sach.TheLoai = dr["TheLoai"].ToString();
                Sach.TacGia = dr["TacGia"].ToString();
                Sach.DonGia = float.Parse(dr["DonGia"].ToString());
                Sach.SoLuongTon = int.Parse(dr["SoLuongTon"].ToString());
                Sach.TinhTrang = int.Parse(dr["TinhTrang"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Sach;
        }

        public static bool CheckSachByMaSach(string maSach)
        {
            var result = false;
            try
            {
                var dt = DataAccessHelper.ExecuteQuery(
                    $"Select MaSach From Sach where MaSach = '{maSach}'");
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

        public static string GenerateNewMaSach()
        {
            string newMaSach = "";
            try
            {
                var dt = DataAccessHelper.ExecuteQuery("GenerateNewMaSach");
                //    "Select MAX(CAST(REPLACE(REPLACE(MaKhachHang, 'K   ', ''), '', '') as int)) + 1 as NewMaKhachHangfrom Sach");
                //newMaKhachHang= dt.Rows[0]["NewMaSach"].ToString() == "" ?
                //    1 :
                //    int.Parse(dt.Rows[0]["NewMaKhachHang"].ToString());
                int temp = int.Parse(dt.Rows[0]["NewMaSach"].ToString());
                newMaSach = $"SACH{temp:0000}";
                return newMaSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
