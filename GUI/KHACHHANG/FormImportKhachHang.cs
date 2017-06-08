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

namespace GUI.KHACHHANG
{
    public partial class FormImportKhachHang : Form
    {
        public FormImportKhachHang()
        {
            InitializeComponent();
        }

        private void FormImportKhachHang_Load(object sender, EventArgs e)
        {
            RefreshBase();
        }

        private void RefreshBase()
        {
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Mã khách hàng"].Value = KhachHangBUS.GenerateNewMaKhachHang();
        }
        private void dataGridView1_DefaultValuesNeeded(object sender, System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            //e.Row.Cells["Mã khách hàng"].Value = KhachHangBUS.GenerateNewMaKhachHang();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["maKH_col"].Value = KhachHangBUS.GenerateNewMaKhachHang();
        }

        private void import_button_Click(object sender, EventArgs e)
        {
            //int temp = int.Parse(_baseMaKhachHang.Substring(2)) + (_index++);
            //DataGridViewRow dgvr = new System.Windows.Forms.DataGridViewRow();
            //dgvr.CreateCells(dataGridView1);
            ////dgvr.Cells[0].Value = String.Format("KH{0:0000}", temp);
            //dgvr.Cells[0].Value = $"KH{temp:0000}";
            //dataGridView1.Rows.Add(dgvr);
            
            List<KhachHangDTO> listKhachHang = new List<KhachHangDTO>();

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(!row.IsNewRow)
                {
                    KhachHangDTO temp = new KhachHangDTO
                    {
                        HoTenKhachHang = row.Cells["hoten_col"].Value.ToString(),
                        DiaChi = row.Cells["diachi_col"].Value == null? "": row.Cells["diachi_col"].Value.ToString(),
                        SoDienThoai = row.Cells["sdt_col"].Value == null ? "" : row.Cells["sdt_col"].Value.ToString(),
                        Email = row.Cells["email_col"].Value == null ? "" : row.Cells["email_col"].Value.ToString(),
                    };

                   listKhachHang.Add(temp);
                }
            }

            if(KhachHangBUS.InsertKhachHang(listKhachHang))
            {
                MessageBox.Show("Nhập khách hàng thành công!", "Thành công");
            }


        }
    }
}
