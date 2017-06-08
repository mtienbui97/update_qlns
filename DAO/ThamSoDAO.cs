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
    public class ThamSoDAO
    {
        #region 2. Updating

        public static bool UpdateSoLuongNhapItNhat(int soLuongNhapItNhat)
        {
            var result = false;
            try
            {

                var n = DataAccessHelper.ExecuteNonQuery(
                    $"Update ThamSo Set SoLuongNhapItNhat = {soLuongNhapItNhat}");
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

        public static bool UpdateThamSo(ThamSoDTO thamso)
        {
            var result = false;
            try
            {
                List<MySqlParameter> parameters = new List<MySqlParameter>();
                parameters.Add(new MySqlParameter("p_SoLuongNhapToiThieu",thamso.SoLuongNhapItNhat));
                parameters.Add(new MySqlParameter("p_SoLuongTonToiDaTruocNhap", thamso.SoLuongTonToiDaTruocNhap));
                parameters.Add(new MySqlParameter("p_SoLuongTonToiThieuSauBan", thamso.SoLuongTonToiThieuSauBan));
                parameters.Add(new MySqlParameter("p_SoTienNoToiDa", thamso.SoTienNoToiDa));
                parameters.Add(new MySqlParameter("p_SuDungQuiDinh4", thamso.SuDungQuiDinh4));

                var n = DataAccessHelper.ExecuteNonQuery("UpdateThamSo", parameters);
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

        public static bool UpdateSoLuongTonToiDaTruocNhap(int soLuongTonToiDaTruocNhap)
        {
            var result = false;
            try
            {
                var n = DataAccessHelper.ExecuteNonQuery(
                    $"Update ThamSo Set SoLuongTonToiDaTruocNhap = {soLuongTonToiDaTruocNhap}");
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

        public static ThamSoDTO SelectThamSoAll ()
        {
            
            var thamso = new ThamSoDTO();
            var dt = DataAccessHelper.ExecuteQuery("SelectThamSoAll");
            var dr = dt.Rows[0];
            
            thamso.SoLuongNhapItNhat = int.Parse(dr["SoLuongNhapToiThieu"].ToString());
            thamso.SoLuongTonToiDaTruocNhap = int.Parse(dr["SoLuongTonToiDaTruocNhap"].ToString());
            thamso.SoLuongTonToiThieuSauBan = int.Parse(dr["SoLuongTonToiThieuSauBan"].ToString());
            thamso.SoTienNoToiDa = int.Parse(dr["SoTienNoToiDa"].ToString());
            thamso.SuDungQuiDinh4 = Boolean.Parse(dr["SuDungQuyDinh4"].ToString());
            
            return thamso;
        }

        //public static int SelectSoLuongNhapItNhat()
        //{
        //    var soLuongNhapItNhat = 0;
        //    try
        //    {
                
        //    //    var dt = DataAccessHelper.ExecuteQuery(
        //    //        $"Select SoLuongNhapItNhat from ThamSo");
        //     var dr = dt.Rows[0];
        //         = int.Parse(dt.Rows.ToString());
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //    return soLuongNhapItNhat;
        //}

        public static int SelectSoLuongTonToiDaTruocNhap()
        {
            var soLuongTonToiDaTruocNhap = 0;
            try
            {
                var dt = DataAccessHelper.ExecuteQuery(
                    $"Select SoLuongTonToiDaTruocNhap from ThamSo");
                var dr = dt.Rows[0];
                soLuongTonToiDaTruocNhap = int.Parse(dr["SoLuongTonToiDaTruocNhap"].ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return soLuongTonToiDaTruocNhap;
        }

        #endregion
    }
}
