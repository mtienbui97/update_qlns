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
    public partial class FormThayDoiQuyDinh : Form
    {
        public FormThayDoiQuyDinh()
        {
            InitializeComponent();
        }

        private void FormThayDoiQuyDinh_Load(object sender, EventArgs e)
        {
            var thamso = new ThamSoDTO();
            thamso = ThamSoBUS.SelectThamSoAll();
            slNhap_tb.Text = thamso.SoLuongNhapItNhat.ToString();
            slTonTruocNhap_tb.Text = thamso.SoLuongTonToiDaTruocNhap.ToString();
            slTonSauBan_tb.Text = thamso.SoLuongTonToiThieuSauBan.ToString();
            tienNo_tb.Text = thamso.SoTienNoToiDa.ToString();
            sudungquidinh.Checked = thamso.SuDungQuiDinh4;
        }

        private void capnhat_bt_Click(object sender, EventArgs e)
        {
            var thamso = new ThamSoDTO();   
            thamso.SoLuongNhapItNhat = int.Parse(slNhap_tb.Text);
            thamso.SoLuongTonToiDaTruocNhap = int.Parse(slTonTruocNhap_tb.Text);
            thamso.SoLuongTonToiThieuSauBan = int.Parse(slTonSauBan_tb.Text);
            thamso.SoTienNoToiDa = int.Parse(tienNo_tb.Text);
            thamso.SuDungQuiDinh4 = sudungquidinh.Checked;

            if (ThamSoBUS.UpdateThamSo(thamso))
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("Thất bại!");
            };
        }
    }
}
