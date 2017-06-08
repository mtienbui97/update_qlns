using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class FormThemSachfromHoaDon : Form
    {
        private FormLapHoaDon _parentForm;
        public FormThemSachfromHoaDon(FormLapHoaDon parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void TenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sach = (SachDTO)TenSach.SelectedItem;

            MaSach.Text = sach.MaSach;
            TheLoai.Text = sach.TheLoai;
            TacGia.Text = sach.TacGia;
            soluongton_tb.Text = sach.SoLuongTon.ToString();
            dongia_tb.Text = sach.DonGia.ToString();
        }

        private void FormLapChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            TenSach.DataSource = SachBUS.SelectSachAll();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            if (TenSach.SelectedItem == null)
            {
                MessageBox.Show(@"Chưa chọn sách", @"Lỗi");
            }
            else if (soluongban.Value <= 0)
            {
                MessageBox.Show(@"Số lượng nhập không hợp lệ", @"Lỗi");
            }
            else
            {
                _parentForm.ThemChiTietHoaDon((SachDTO)TenSach.SelectedItem, (int)soluongban.Value, decimal.Parse(thanhtien_tb.Text), decimal.Parse(dongiaban_tb.Text) );
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dongiaban_tb_TextChanged(object sender, EventArgs e)
        {
            if(dongiaban_tb.Text == "")
            {
                thanhtien_tb.Text = "0";
                return;
            }

            if ((soluongban.Value != 0) && (decimal.Parse(dongiaban_tb.Text) != 0))
            {
                decimal temp = int.Parse(dongiaban_tb.Text) * soluongban.Value;
                thanhtien_tb.Text = temp.ToString();
            }
        }

        private void soluongban_ValueChanged(object sender, EventArgs e)
        {
            if (dongiaban_tb.Text == "")
            {
                thanhtien_tb.Text = "0";
                return;
            }

            if ((soluongban.Value != 0) && (decimal.Parse(dongiaban_tb.Text) != 0))
            {
                decimal temp = int.Parse(dongiaban_tb.Text) * soluongban.Value;
                thanhtien_tb.Text = temp.ToString();
            }
        }
    }
}
