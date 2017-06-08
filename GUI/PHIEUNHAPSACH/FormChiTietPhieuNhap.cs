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
    public partial class FormChiTietPhieuNhap : Form
    {
        private FormLapPhieuNhapSach _parentForm;
        public FormChiTietPhieuNhap( FormLapPhieuNhapSach parentForm)
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
            DonGia.Text = sach.DonGia.ToString();
            SoLuongTon.Text = sach.SoLuongTon.ToString();
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
            else if (SoLuongNhap.Value <= 0)
            {
                MessageBox.Show(@"Số lượng nhập không hợp lệ", @"Lỗi");
            }
            else
            {
                _parentForm.ThemChiTietPhieuNhap((SachDTO)TenSach.SelectedItem, (int)SoLuongNhap.Value);
            }
        }

        private void SoLuongNhap_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
