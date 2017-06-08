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
    public class KhachHangDAO
    {
        #region 1. Inserting

        public static bool InsertKhachHang(KhachHangDTO khachhang )
        {
            var result = false;
            try
            {
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Insert into Sach values('{sach.MaSach}', '{sach.HoTenKhachHang}', '{sach.DiaChi}', '{sach.SoDienThoai}', '{sach.Email}', '{sach.SoTienNo}')");


                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaKhachHang", khachhang.MaKhachHang));
                parameters.Add(new MySqlParameter("p_HoTenKhachHang", khachhang.HoTenKhachHang));
                parameters.Add(new MySqlParameter("p_DiaChi", khachhang.DiaChi));
                parameters.Add(new MySqlParameter("p_DienThoai", khachhang.SoDienThoai));
                parameters.Add(new MySqlParameter("p_SoTienNo", khachhang.SoTienNo));
                parameters.Add(new MySqlParameter("p_Email", khachhang.Email));
                parameters.Add(new MySqlParameter("P_TinhTrang", khachhang.TinhTrang));
                var n = DataAccessHelper.ExecuteNonQuery("InsertKhachHang", parameters);

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

        public static bool UpdateKhachHang(KhachHangDTO khachhang)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaKhachHang", khachhang.MaKhachHang));
                parameters.Add(new MySqlParameter("p_HoTenKhachHang", khachhang.HoTenKhachHang));
                parameters.Add(new MySqlParameter("p_DiaChi", khachhang.DiaChi));
                parameters.Add(new MySqlParameter("p_SoDienThoai", khachhang.SoDienThoai));
                parameters.Add(new MySqlParameter("p_SoTienNo", khachhang.SoTienNo));
                parameters.Add(new MySqlParameter("p_Email", khachhang.Email));
                parameters.Add(new MySqlParameter("P_TinhTrang", khachhang.TinhTrang));
                var n = DataAccessHelper.ExecuteNonQuery("UpdateKhachHang", parameters);
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Update Sach Set HoTenKhachHang = '{Sach.HoTenKhachHang}', DiaChi = '{Sach.DiaChi}', SoDienThoai = '{Sach.SoDienThoai}', Email = '{Sach.Email}', SoTienNo = '{Sach.SoTienNo}' where MaKhachHang= '{Sach.MaSach}'");
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

        public static bool DeleteKhachByMaKhachHang(string maKhachHang)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaKhachHang", maKhachHang));
                var n = DataAccessHelper.ExecuteNonQuery("DeleteKhachHangByMaKhachHang", parameters);
                //var n = DataAccessHelper.ExecuteNonQuery(
                //    $"Delete From Sach Where MaKhachHang= '{maSach}'");
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

        public static List<KhachHangDTO> SelectKhachHangAll()
        {
            var list = new List<KhachHangDTO>();
            try
            {
                var dt = DataAccessHelper.ExecuteQuery("SelectKhachHangAll");
                //var dt = DataAccessHelper.ExecuteQuery(
                //    "Select MaSach, HoTenKhachHang, DiaChi, SoDienThoai, Email, SoTienNo From Sach");
                list.AddRange(from DataRow dr in dt.Rows
                                select new KhachHangDTO
                              {
                                  MaKhachHang= dr["MaSach"].ToString(),
                                  HoTenKhachHang = dr["HoTenKhachHang"].ToString(),
                                  DiaChi = dr["DiaChi"].ToString(),
                                  SoDienThoai = dr["SoDienThoai"].ToString(),
                                  Email = dr["Email"].ToString(),
                                  SoTienNo = decimal.Parse(dr["SoTienNo"].ToString())
                              });
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        public static KhachHangDTO SelectKhachHangByMaKhachHang(string maKhachHang)
        {
            var khachhang = new KhachHangDTO();
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_MaKhachHang", maKhachHang));
                var dt = DataAccessHelper.ExecuteQuery("SelectKhachHangByMaKhachHang", parameters);
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaSach, HoTenKhachHang, DiaChi, SoDienThoai, Email, SoTienNo From Sach Where MaKhachHang= '{maSach}'");
                var dr = dt.Rows[0];
                khachhang.MaKhachHang= dr["MaKhachHang"].ToString();
                khachhang.HoTenKhachHang = dr["HoTenKhachHang"].ToString();
                khachhang.DiaChi = dr["DiaChi"].ToString();
                khachhang.SoDienThoai = dr["DienThoai"].ToString();
                khachhang.Email = dr["Email"].ToString();
                khachhang.SoTienNo = decimal.Parse(dr["SoTienNo"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return khachhang;
        }

        public static bool CheckKhachHangByMaKhachHang(string maKhachHang)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_maKhachHang", maKhachHang));
                var dt = DataAccessHelper.ExecuteQuery("SelectKhachHangByMaKhachHang", parameters);
                //var dt = DataAccessHelper.ExecuteQuery(
                //    $"Select MaKhachHangFrom KHACHHANG where MaKhachHang= '{maKhachHang}'");
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

        public static string GenerateNewMaKhachHang()
        {
            string newMaKhachHang= "";
            try
            {
                var dt = DataAccessHelper.ExecuteQuery("GenerateNewMaKhachHang");
                //    "Select MAX(CAST(REPLACE(REPLACE(MaKhachHang, 'K   ', ''), '', '') as int)) + 1 as NewMaKhachHangfrom Sach");
                //newMaKhachHang= dt.Rows[0]["NewMaSach"].ToString() == "" ?
                //    1 :
                //    int.Parse(dt.Rows[0]["NewMaKhachHang"].ToString());
                int temp = int.Parse(dt.Rows[0]["NewMaKhachHang"].ToString());
                newMaKhachHang = $"KH{temp:0000}";
                return newMaKhachHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
