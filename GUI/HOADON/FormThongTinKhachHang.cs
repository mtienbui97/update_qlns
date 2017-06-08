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
    public partial class FormThongTinKhachHang : Form
    {
        public FormThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void thoat_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormThongTinKhachHang_Load(object sender, EventArgs e)
        {
           
        }

        public void RefreshFormThongTin(string maKhachHang)
        {
            var khachhang = new KhachHangDTO();
            khachhang = KhachHangBUS.SelectKhachHangByMaKhachHang(maKhachHang);
            maKhachHang_tb.Text = khachhang.MaKhachHang;
            hoTenKH_tb.Text = khachhang.HoTenKhachHang;
            diachi_tb.Text = khachhang.DiaChi;
            sdt_tb.Text = khachhang.SoDienThoai;
            email_tb.Text = khachhang.Email;
            tienno_tb.Text = khachhang.SoTienNo.ToString();
        }

        //private void FormThongTinKhachHang_Load(object sender, EventArgs e)
        //{
        //    var khachhang = new KhachHangDTO();
        //    var hoadonForm = new FormLapHoaDon();
        //    khachhang = KhachHangBUS.SelectKhachHangByMaKhachHang(hoadonForm.GetTextfromTextBox(hoadonForm.maKah)
        //    maKhachHang_tb.Text = 
        //}
    }
}
