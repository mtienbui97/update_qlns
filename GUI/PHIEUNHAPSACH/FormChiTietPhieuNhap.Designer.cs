namespace GUI
{
    partial class FormChiTietPhieuNhap
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
            this.DonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SoLuongTon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Them = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SoLuongNhap = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongNhap)).BeginInit();
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
            this.TenSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TenSach.Name = "TenSach";
            this.TenSach.Size = new System.Drawing.Size(82, 21);
            this.TenSach.TabIndex = 1;
            this.TenSach.SelectedIndexChanged += new System.EventHandler(this.TenSach_SelectedIndexChanged);
            // 
            // MaSach
            // 
            this.MaSach.Location = new System.Drawing.Point(109, 14);
            this.MaSach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            this.MaSach.Size = new System.Drawing.Size(82, 20);
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
            this.TheLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            this.TheLoai.Size = new System.Drawing.Size(82, 20);
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
            this.TacGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            this.TacGia.Size = new System.Drawing.Size(82, 20);
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
            // DonGia
            // 
            this.DonGia.Location = new System.Drawing.Point(109, 144);
            this.DonGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Size = new System.Drawing.Size(82, 20);
            this.DonGia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Đơn giá";
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.Location = new System.Drawing.Point(109, 177);
            this.SoLuongTon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.ReadOnly = true;
            this.SoLuongTon.Size = new System.Drawing.Size(82, 20);
            this.SoLuongTon.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 181);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số lượng tồn";
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(76, 237);
            this.Them.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.label7.Location = new System.Drawing.Point(19, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số lượng nhập";
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.Location = new System.Drawing.Point(109, 209);
            this.SoLuongNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SoLuongNhap.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.Size = new System.Drawing.Size(80, 20);
            this.SoLuongNhap.TabIndex = 17;
            this.SoLuongNhap.ValueChanged += new System.EventHandler(this.SoLuongNhap_ValueChanged);
            // 
            // FormChiTietPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 272);
            this.Controls.Add(this.SoLuongNhap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.SoLuongTon);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TacGia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TheLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaSach);
            this.Controls.Add(this.TenSach);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormChiTietPhieuNhap";
            this.Text = "FormLapChiTietPhieuNhap";
            this.Load += new System.EventHandler(this.FormLapChiTietPhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SoLuongNhap)).EndInit();
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
        private System.Windows.Forms.TextBox DonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SoLuongTon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown SoLuongNhap;
    }
}