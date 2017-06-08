using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuThuTienBUS
    {
        public static bool InsertPhieuThuTien(PhieuThuTienDTO phieuthu)
        {
            var baocaocongno_moi = new BaoCaoCongNoDTO();
            var baocaocongno_truoc = new BaoCaoCongNoDTO();
                baocaocongno_truoc = BaoCaoCongNoBUS.SelectBaoCaoCongNoThangGanNhatByMaKhachHang(phieuthu.MaKhachHang);
            var khachhang = KhachHangDAO.SelectKhachHangByMaKhachHang(phieuthu.MaKhachHang);
            baocaocongno_moi.MaKhachHang = khachhang.MaKhachHang;
            


            if (ThamSoBUS.CheckApDungQuiDinh4())
            {
                phieuthu.SoTienThu = khachhang.SoTienNo;
            }


            if (phieuthu.NgayThu.Date.ToString() == "1")
            {
                baocaocongno_moi.NoDau = baocaocongno_truoc.NoCuoi;
            }

            if (baocaocongno_moi.NoDau == khachhang.SoTienNo)
            {
                baocaocongno_moi.NoPhatSinh = 0;
                baocaocongno_moi.NoCuoi = khachhang.SoTienNo;
            }

            baocaocongno_moi.NoCuoi = baocaocongno_moi.NoCuoi = phieuthu.SoTienThu;
            baocaocongno_moi.NoPhatSinh = baocaocongno_moi.NoPhatSinh - phieuthu.SoTienThu;
            khachhang.SoTienNo = khachhang.SoTienNo - phieuthu.SoTienThu;
            // if (ton tai bao cao cong no cua Thang hien tai)
            // { update}
            // else {insert}
            if (baocaocongno_truoc.Thang.Month == phieuthu.NgayThu.Month)
            {
                baocaocongno_moi.MaChiTietCongNo = baocaocongno_truoc.MaChiTietCongNo;
                baocaocongno_moi.Thang = baocaocongno_truoc.Thang;
                if (BaoCaoCongNoBUS.UpdateBaoCaoCongNo(baocaocongno_moi))
                {
                    if (PhieuThuTienDAO.InsertPhieuThu(phieuthu))
                    {
                        return true;
                    }
                    else return false;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                baocaocongno_moi.MaChiTietCongNo = BaoCaoCongNoBUS.GenerateNewMaBaoCaoCongNo();
                baocaocongno_moi.Thang = phieuthu.NgayThu;
                if (BaoCaoCongNoBUS.InsertBaoCaoCongNo(baocaocongno_moi))
                {
                    if (PhieuThuTienDAO.InsertPhieuThu(phieuthu))
                    {
                        return true;
                    }
                    else return false;
                }
                else
                {
                    return false;
                }
            }

        }

        public static string GenerateNewMaPhieuThu()
        {
            return PhieuThuTienDAO.GenerateNewMaPhieuThu();
        }
    }
}
