using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormPhieuThuTien : Form
    {
       
        public FormPhieuThuTien()
        {
            InitializeComponent();
        }

        private void FormPhieuThuTien_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private  void RefreshForm()
        {
            maphieu_tb.Text = PhieuThuTienBUS.GenerateNewMaPhieuThu();
            makh_tb.Text = "";
            ten_tb.Text = "";
            diachi_tb.Text = "";
            sdt_tb.Text = "";
            email_tb.Text = "";
            sotienthu_tb.Text = "0";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void makh_tb_TextChanged(object sender, EventArgs e)
        {
            var khachhang = new KhachHangDTO();
            string makhachhang = "";
            if (makh_tb.Text.Length == 6)
            {
                makhachhang = makh_tb.Text;
                if(KhachHangBUS.CheckKhachHangByMaKhachHang(makhachhang))
                {
                    khachhang = KhachHangBUS.SelectKhachHangByMaKhachHang(makhachhang);
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không tồn tại");
                }

                makh_tb.Text = khachhang.MaKhachHang;
                ten_tb.Text = khachhang.HoTenKhachHang;
                diachi_tb.Text = khachhang.DiaChi;
                sdt_tb.Text = khachhang.SoDienThoai;
                email_tb.Text = khachhang.Email;
            }
            //else {do nothing}
        }

        private void lapphieu_button_Click(object sender, EventArgs e)
        {
            var phieuthu = new PhieuThuTienDTO();
            phieuthu.MaPhieuThu = maphieu_tb.Text;
            phieuthu.MaKhachHang = makh_tb.Text;
            phieuthu.NgayThu = DateTime.Parse(dateTimePicker1.Text);
            phieuthu.SoTienThu = decimal.Parse(sotienthu_tb.Text);
            if (PhieuThuTienBUS.InsertPhieuThuTien(phieuthu))
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }
        }
    }
}
