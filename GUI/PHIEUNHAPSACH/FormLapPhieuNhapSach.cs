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
    public partial class FormLapPhieuNhapSach : Form
    {
        private BindingSource _bindingSource;
        private DataTable _dataTable;
        private FormChiTietPhieuNhap _childForm;

        public FormLapPhieuNhapSach()
        {
            InitializeComponent();

            _dataTable = new DataTable();
            _dataTable.Columns.Add("Mã sách");
            _dataTable.Columns.Add("Tên sách");
            _dataTable.Columns.Add("Thể loại");
            _dataTable.Columns.Add("Tác giả");
            _dataTable.Columns.Add("Đơn giá");
            _dataTable.Columns.Add("Số lượng tồn");
            _dataTable.Columns.Add("Số lượng nhập");

            _bindingSource = new BindingSource
            {
                DataSource = _dataTable
            };
        }

        private void FormLapPhieuNhapSach_Load(object sender, EventArgs e)
        {
            RefreshForm();
            DataGridChiTietPhieuNhap.DataSource = _bindingSource;
        }

        private void RefreshForm()
        {
            MaPhieuNhap.Text = PhieuNhapBUS.GenerateNewMaPhieuNhap();
            NgayNhap.Value = DateTime.Now;
            SoLuongNhapItNhat.Text = ThamSoBUS.SelectSoLuongNhapItNhat().ToString();
            SoLuongTonToiDaTruocNhap.Text = ThamSoBUS.SelectSoLuongTonToiDaTruocNhap().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var phieuNhap = new PhieuNhapDTO
            {
                MaPhieuNhap = MaPhieuNhap.Text,
                NgayNhap = NgayNhap.Value
            };

            var listChiTietPhieuNhap = new List<ChiTietPhieuNhapDTO>();
            foreach (DataGridViewRow row in DataGridChiTietPhieuNhap.Rows)
            {
                if (row.Cells["Số lượng nhập"].Value == null || int.Parse(row.Cells["Số lượng nhập"].Value.ToString()) == 0)
                {
                    continue;
                }
                var chiTietPhieuNhap = new ChiTietPhieuNhapDTO
                {
                    MaPhieuNhap = MaPhieuNhap.Text,
                    MaSach = row.Cells["Mã sách"].Value.ToString(),
                    SoLuongNhap = int.Parse(row.Cells["Số lượng nhập"].Value.ToString())
                };

                listChiTietPhieuNhap.Add(chiTietPhieuNhap);
            }

            if (listChiTietPhieuNhap.Count == 0)
            {
                MessageBox.Show(@"Phiếu nhập rỗng", @"Lỗi");
            }

            try
            {
                PhieuNhapBUS.InsertPhieuNhap(phieuNhap, listChiTietPhieuNhap);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Lỗi");
            }

            RefreshForm();
        }

        private void ThemSach_Click(object sender, EventArgs e)
        {
            if (_childForm == null || _childForm.IsDisposed)
            {
                _childForm = new FormChiTietPhieuNhap(this);
                _childForm.Show();
            }
        }

        public void ThemChiTietPhieuNhap(SachDTO sach, int soLuongNhap)
        {
            foreach (DataRow dataRow in _dataTable.Rows)
            {
                if (sach.MaSach != dataRow["Mã sách"].ToString())
                {
                    continue;
                }

                dataRow["Số lượng nhập"] =
                    int.Parse(dataRow["Số lượng nhập"].ToString()) + soLuongNhap;

                return;
            }

            var row = _dataTable.NewRow();
            row["Mã sách"] = sach.MaSach;
            row["Tên sách"] = sach.TenSach;
            row["Thể loại"] = sach.TheLoai;
            row["Tác giả"] = sach.TacGia;
            row["Đơn giá"] = sach.DonGia;
            row["Số lượng tồn"] = sach.SoLuongTon;
            row["Số lượng nhập"] = soLuongNhap;
            _dataTable.Rows.Add(row);
        }

        private void XoaSach_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridChiTietPhieuNhap.SelectedRows)
            {
                _dataTable.Rows.Cast<DataRow>().Where(
                    r => r["Mã sách"] == row.Cells["Mã sách"].Value).ToList().ForEach(r => r.Delete());
            }
        }
    }
}
