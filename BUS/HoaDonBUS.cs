using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;

using DTO;

namespace BUS
{
    public class HoaDonBUS
    {
        #region 1. Inserting

        public static bool InsertHoaDon(HoaDonDTO HoaDon, List<ChiTietHoaDonDTO> listChiTietHoaDon)
        {
            var baocaoton_moi = new BaoCaoTonDTO();
            var baocaoton_truoc = new BaoCaoTonDTO();

            if(KhachHangDAO.SelectKhachHangByMaKhachHang(HoaDon.MaKhachHang).SoTienNo > ThamSoDAO.SelectThamSoAll().SoTienNoToiDa)
            {
                throw new Exception(
                       $"Khách hàng có mã {HoaDon.MaKhachHang} có nợ nhiều hơn {ThamSoDAO.SelectThamSoAll().SoTienNoToiDa}");
            }

            foreach (var chiTietHoaDon in listChiTietHoaDon)
            {

                if ((SachDAO.SelectSachByMaSach(chiTietHoaDon.MaSach).SoLuongTon - chiTietHoaDon.SoLuongBan) < ThamSoDAO.SelectThamSoAll().SoLuongTonToiThieuSauBan)
                {
                    throw new Exception(
                        $"Sách có mã {chiTietHoaDon.MaSach} có số lượng tồn sau bán ít hơn {ThamSoDAO.SelectThamSoAll().SoLuongTonToiThieuSauBan}");
                }
            }

            HoaDonDAO.InsertHoaDon(HoaDon);
            foreach (var chiTietHoaDon in listChiTietHoaDon)
            {
                chiTietHoaDon.MaChiTietHoaDon = ChiTietHoaDonDAO.GenerateNewMaChiTietHoaDon();
                baocaoton_truoc = BaoCaoTonBUS.SelectBaoCaoTonThangGanNhatByMaSach(chiTietHoaDon.MaSach);

                ChiTietHoaDonDAO.InsertChiTietHoaDon(chiTietHoaDon);
                SachDTO sach = SachDAO.SelectSachByMaSach(chiTietHoaDon.MaSach);
                sach.SoLuongTon += chiTietHoaDon.SoLuongBan;
                SachDAO.UpdateSach(sach);
                baocaoton_moi.MaSach = sach.MaSach;
                baocaoton_moi.Thang = HoaDon.NgayLapHoaDon;

                if (HoaDon.NgayLapHoaDon.Date.ToString() == "1")
                {
                    baocaoton_moi.TonDau = baocaoton_truoc.TonCuoi;
                }

                if (baocaoton_moi.TonDau == sach.SoLuongTon)
                {
                    baocaoton_moi.TonPhatSinh = 0;
                    baocaoton_moi.TonCuoi = sach.SoLuongTon;
                }

                baocaoton_moi.TonCuoi = baocaoton_moi.TonCuoi = chiTietHoaDon.SoLuongBan;
                baocaoton_moi.TonPhatSinh = baocaoton_moi.TonPhatSinh - chiTietHoaDon.SoLuongBan;
                sach.SoLuongTon = sach.SoLuongTon - chiTietHoaDon.SoLuongBan;

                if (baocaoton_truoc.Thang.Month == HoaDon.NgayLapHoaDon.Month)
                {
                    baocaoton_moi.MaChiTietTon = baocaoton_truoc.MaChiTietTon;
                    baocaoton_moi.Thang = baocaoton_truoc.Thang;
                    if (BaoCaoTonBUS.UpdateBaoCaoTon(baocaoton_moi))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    baocaoton_moi.MaChiTietTon = BaoCaoTonBUS.GenerateNewMaBaoCaoTon();
                    baocaoton_moi.Thang = HoaDon.NgayLapHoaDon;
                    if (BaoCaoTonBUS.InsertBaoCaoTon(baocaoton_moi))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }

            return true;
        }

        #endregion
        #region 2. Update

        #endregion
        #region 4. Retrieving

        public static string GenerateNewMaHoaDon()
        {
            return HoaDonDAO.GenerateNewMaHoaDon();
        }

        #endregion
    }
}
