using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAO;

using DTO;

namespace BUS
{
    public class PhieuNhapBUS
    {
        #region 1. Inserting

        public static bool InsertPhieuNhap(PhieuNhapDTO phieuNhap, List <ChiTietPhieuNhapDTO> listChiTietPhieuNhap)
        {
            var baocaoton_moi = new BaoCaoTonDTO();
            var baocaoton_truoc = new BaoCaoTonDTO();
            
            if (PhieuNhapDAO.CheckPhieuNhapByMaPhieuNhap(phieuNhap.MaPhieuNhap))
            {
                throw new Exception("Mã phiếu nhập đã tồn tại");
            }

            foreach ( var chiTietPhieuNhap in listChiTietPhieuNhap )
            {
                if ( ChiTietPhieuNhapDAO.CheckChiTietPhieuNhapByMaChiTietPhieuNhap (
                    chiTietPhieuNhap.MaChiTietPhieuNhap ) )
                {
                    throw new Exception ( "Mã chi tiết phiếu nhập đã tồn tại" );
                }

                if ( chiTietPhieuNhap.SoLuongNhap < ThamSoDAO.SelectThamSoAll().SoLuongNhapItNhat)
                {
                    throw new Exception (
                        $"Sách có mã {chiTietPhieuNhap.MaSach} có số lượng nhập ít hơn {ThamSoDAO.SelectThamSoAll( ).SoLuongNhapItNhat}" );
                }

                if (SachDAO.SelectSachByMaSach(chiTietPhieuNhap.MaSach).SoLuongTon >
                     ThamSoDAO.SelectSoLuongTonToiDaTruocNhap())
                {
                    throw new Exception(
                        $"Sách có mã {chiTietPhieuNhap.MaSach} có số lượng tồn nhiều hơn {ThamSoDAO.SelectSoLuongTonToiDaTruocNhap()}");
                }
            }

            PhieuNhapDAO.InsertPhieuNhap(phieuNhap);
            foreach ( var chiTietPhieuNhap in listChiTietPhieuNhap )
            {
                chiTietPhieuNhap.MaChiTietPhieuNhap = ChiTietPhieuNhapDAO.GenerateNewMaChiTietPhieuNhap ( );
                baocaoton_truoc = BaoCaoTonBUS.SelectBaoCaoTonThangGanNhatByMaSach(chiTietPhieuNhap.MaSach);
                
                ChiTietPhieuNhapDAO.InsertChiTietPhieuNhap ( chiTietPhieuNhap );
                SachDTO sach = SachDAO.SelectSachByMaSach(chiTietPhieuNhap.MaSach);
                sach.SoLuongTon += chiTietPhieuNhap.SoLuongNhap;
                SachDAO.UpdateSach(sach);
                baocaoton_moi.MaSach = sach.MaSach;
                baocaoton_moi.Thang = phieuNhap.NgayNhap;

                if (phieuNhap.NgayNhap.Date.ToString() == "1")
                {
                    baocaoton_moi.TonDau = baocaoton_truoc.TonCuoi;
                }

                if (baocaoton_moi.TonDau == sach.SoLuongTon)
                {
                    baocaoton_moi.TonPhatSinh = 0;
                    baocaoton_moi.TonCuoi = sach.SoLuongTon;
                }

                baocaoton_moi.TonCuoi = baocaoton_moi.TonCuoi = chiTietPhieuNhap.SoLuongNhap;
                baocaoton_moi.TonPhatSinh = baocaoton_moi.TonPhatSinh + chiTietPhieuNhap.SoLuongNhap;
                sach.SoLuongTon = sach.SoLuongTon + chiTietPhieuNhap.SoLuongNhap;

                if (baocaoton_truoc.Thang.Month == phieuNhap.NgayNhap.Month)
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
                    baocaoton_moi.Thang = phieuNhap.NgayNhap;
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

        public static string GenerateNewMaPhieuNhap ( )
        {
            return PhieuNhapDAO.GenerateNewMaPhieuNhap ( );
        }

        #endregion
    }
}
