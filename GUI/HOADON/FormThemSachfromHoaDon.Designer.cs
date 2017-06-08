namespace GUI
{
    partial class FormThemSachfromHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TenSach = new System.Windows.Forms.ComboBox();
            this.MaSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TheLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TacGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.soluongton_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dongia_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Them = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.soluongban = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.thanhtien_tb = new System.Windows.Forms.TextBox();
            this.lable9 = new System.Windows.Forms.Label();
            this.dongiaban_tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.soluongban)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách";
            // 
            // TenSach
            // 
            this.TenSach.DisplayMember = "TenSach";
            this.TenSach.FormattingEnabled = true;
            this.TenSach.Location = new System.Drawing.Point(109, 47);
            this.TenSach.Margin = new System.Windows.Forms.Padding(2);
            this.TenSach.Name = "TenSach";
            this.TenSach.Size = new System.Drawing.Size(80, 21);
            this.TenSach.TabIndex = 1;
            this.TenSach.SelectedIndexChanged += new System.EventHandler(this.TenSach_SelectedIndexChanged);
            // 
            // MaSach
            // 
            this.MaSach.Location = new System.Drawing.Point(109, 14);
            this.MaSach.Margin = new System.Windows.Forms.Padding(2);
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Size = new System.Drawing.Size(80, 20);
            this.MaSach.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sách";
            // 
            // TheLoai
            // 
            this.TheLoai.Location = new System.Drawing.Point(109, 79);
            this.TheLoai.Margin = new System.Windows.Forms.Padding(2);
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            this.TheLoai.Size = new System.Drawing.Size(80, 20);
            this.TheLoai.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thể loại";
            // 
            // TacGia
            // 
            this.TacGia.Location = new System.Drawing.Point(109, 112);
            this.TacGia.Margin = new System.Windows.Forms.Padding(2);
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            this.TacGia.Size = new System.Drawing.Size(80, 20);
            this.TacGia.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tác giả";
            // 
            // soluongton_tb
            // 
            this.soluongton_tb.Location = new System.Drawing.Point(109, 144);
            this.soluongton_tb.Margin = new System.Windows.Forms.Padding(2);
            this.soluongton_tb.Name = "soluongton_tb";
            this.soluongton_tb.ReadOnly = true;
            this.soluongton_tb.Size = new System.Drawing.Size(80, 20);
            this.soluongton_tb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn giá bán";
            // 
            // dongia_tb
            // 
            this.dongia_tb.Location = new System.Drawing.Point(109, 171);
            this.dongia_tb.Margin = new System.Windows.Forms.Padding(2);
            this.dongia_tb.Name = "dongia_tb";
            this.dongia_tb.ReadOnly = true;
            this.dongia_tb.Size = new System.Drawing.Size(80, 20);
            this.dongia_tb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số lượng tồn";
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(88, 307);
            this.Them.Margin = new System.Windows.Forms.Padding(2);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(50, 21);
            this.Them.TabIndex = 15;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số lượng bán";
            // 
            // soluongban
            // 
            this.soluongban.Location = new System.Drawing.Point(109, 234);
            this.soluongban.Margin = new System.Windows.Forms.Padding(2);
            this.soluongban.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.soluongban.Name = "soluongban";
            this.soluongban.Size = new System.Drawing.Size(80, 20);
            this.soluongban.TabIndex = 17;
            this.soluongban.ValueChanged += new System.EventHandler(this.soluongban_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 264);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Thành tiền";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // thanhtien_tb
            // 
            this.thanhtien_tb.Location = new System.Drawing.Point(107, 261);
            this.thanhtien_tb.Margin = new System.Windows.Forms.Padding(2);
            this.thanhtien_tb.Name = "thanhtien_tb";
            this.thanhtien_tb.ReadOnly = true;
            this.thanhtien_tb.Size = new System.Drawing.Size(82, 20);
            this.thanhtien_tb.TabIndex = 19;
            this.thanhtien_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lable9
            // 
            this.lable9.AutoSize = true;
            this.lable9.Location = new System.Drawing.Point(19, 178);
            this.lable9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable9.Name = "lable9";
            this.lable9.Size = new System.Drawing.Size(47, 13);
            this.lable9.TabIndex = 20;
            this.lable9.Text = "Đơn giá ";
            // 
            // dongiaban_tb
            // 
            this.dongiaban_tb.Location = new System.Drawing.Point(109, 200);
            this.dongiaban_tb.Margin = new System.Windows.Forms.Padding(2);
            this.dongiaban_tb.Name = "dongiaban_tb";
            this.dongiaban_tb.Size = new System.Drawing.Size(80, 20);
            this.dongiaban_tb.TabIndex = 21;
            this.dongiaban_tb.TextChanged += new System.EventHandler(this.dongiaban_tb_TextChanged);
            // 
            // FormThemSachfromHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 339);
            this.Controls.Add(this.dongiaban_tb);
            this.Controls.Add(this.lable9);
            this.Controls.Add(this.thanhtien_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.soluongban);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.dongia_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.soluongton_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TacGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TheLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaSach);
            this.Controls.Add(this.TenSach);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormThemSachfromHoaDon";
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.FormLapChiTietPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soluongban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TenSach;
        private System.Windows.Forms.TextBox MaSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TheLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TacGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox soluongton_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dongia_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown soluongban;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox thanhtien_tb;
        private System.Windows.Forms.Label lable9;
        private System.Windows.Forms.TextBox dongiaban_tb;
    }
}