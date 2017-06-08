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
    public partial class FormLapHoaDon : Form
    {
        private BindingSource _bindingSource;
        private DataTable _dataTable;
        private FormThemSachfromHoaDon _childForm;

        public FormLapHoaDon()
        {
            InitializeComponent();

            _dataTable = new DataTable();
            _dataTable.Columns.Add("Mã sách");
            _dataTable.Columns.Add("Tên sách");
            _dataTable.Columns.Add("Thể loại");
            _dataTable.Columns.Add("Tác giả");
            _dataTable.Columns.Add("Đơn giá bán");
            _dataTable.Columns.Add("Số lượng bán");
            _dataTable.Columns.Add("Thành tiền");

            _bindingSource = new BindingSource
            {
                DataSource = _dataTable
            };
        }

        private void maKhachHang_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void xem_button_Click(object sender, EventArgs e)
        {
            if (KhachHangBUS.CheckKhachHangByMaKhachHang(maKhachHang_tb.Text))
            {
                var thongtinForm = new FormThongTinKhachHang();
                thongtinForm.RefreshFormThongTin(maKhachHang_tb.Text);
                thongtinForm.Show();
            }
            else
            {
                MessageBox.Show("Không tồn tại mã khách hàng");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void themsach_button_Click(object sender, EventArgs e)
        {
            if (_childForm == null || _childForm.IsDisposed)
            {
                _childForm = new FormThemSachfromHoaDon(this);
                _childForm.Show();
            }
        }
    

        private void FormLapHoaDon_Load(object sender, EventArgs e)
        {
            RefreshForm();
            dataGridView1.DataSource = _bindingSource;
        }

        public void ThemChiTietHoaDon(SachDTO sach, int soLuongBan, decimal thanhtien, decimal dongiaban)
        {
            foreach (DataRow dataRow in _dataTable.Rows)
            {
                if (sach.MaSach != dataRow["Mã sách"].ToString())
                {
                    continue;
                }

                dataRow["Số lượng bán"] = int.Parse(dataRow["Số lượng bán"].ToString()) + soLuongBan;
                dataRow["Thành tiền"] = decimal.Parse(dataRow["Thành tiền"].ToString()) + thanhtien;

                tongTien_tb.Text = (decimal.Parse(tongTien_tb.Text) + thanhtien).ToString();
                return;
            }

            var row = _dataTable.NewRow();
            row["Mã sách"] = sach.MaSach;
            row["Tên sách"] = sach.TenSach;
            row["Thể loại"] = sach.TheLoai;
            row["Tác giả"] = sach.TacGia;
            row["Đơn giá bán"] = dongiaban;
            row["Số lượng bán"] = soLuongBan;
            row["Thành tiền"] = thanhtien;
            _dataTable.Rows.Add(row);

            tongTien_tb.Text = (decimal.Parse(tongTien_tb.Text) + thanhtien).ToString();

        }


        private void RefreshForm()
        {
            maHoaDon_tb.Text = HoaDonBUS.GenerateNewMaHoaDon();
            dateTimePicker1.Value = DateTime.Now;
            slTonToiThieuSauBan_tb .Text = ThamSoBUS.SelectSoLuongNhapItNhat().ToString();
            
        }

        public string GetTextfromTextBox (TextBox _textbox)
        {
            return _textbox.Text;
        }

        private void lapPhieuthutien_button_Click(object sender, EventArgs e)
        {

        }

        private void lapHoadon_button_Click(object sender, EventArgs e)
        {
            var hoadon = new HoaDonDTO
            {
                MaHoaDon = maHoaDon_tb.Text,
                NgayLapHoaDon = dateTimePicker1.Value
            };

            var listChiTietHoaDon = new List<ChiTietHoaDonDTO>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Số lượng bán"].Value == null || int.Parse(row.Cells["Số lượng bán"].Value.ToString()) == 0)
                {
                    continue;
                }
                var chiTietHoaDon = new ChiTietHoaDonDTO
                {
                    MaHoaDon = maHoaDon_tb.Text,
                    MaSach = row.Cells["Mã sách"].Value.ToString(),
                    SoLuongBan = int.Parse(row.Cells["Số lượng bán"].Value.ToString())
                };

                listChiTietHoaDon.Add(chiTietHoaDon);
            }

            if (listChiTietHoaDon.Count == 0)
            {
                MessageBox.Show(@"Hóa đơn rỗng", @"Lỗi");
            }

            try
            {
                HoaDonBUS.InsertHoaDon(hoadon, listChiTietHoaDon);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Lỗi");
            }

            RefreshForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                _dataTable.Rows.Cast<DataRow>().Where(
                    r => r["Mã khách hàng"] == row.Cells["Mã khách hàng"].Value).ToList().ForEach(r => r.Delete());
            }
        }
    }
}
    