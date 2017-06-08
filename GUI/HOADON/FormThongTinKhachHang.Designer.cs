namespace GUI
{
    partial class FormThongTinKhachHang
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maKhachHang_tb = new System.Windows.Forms.TextBox();
            this.hoTenKH_tb = new System.Windows.Forms.TextBox();
            this.diachi_tb = new System.Windows.Forms.TextBox();
            this.sdt_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.tienno_tb = new System.Windows.Forms.TextBox();
            this.thoat_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số tiền nợ";
            // 
            // maKhachHang_tb
            // 
            this.maKhachHang_tb.Location = new System.Drawing.Point(111, 24);
            this.maKhachHang_tb.Name = "maKhachHang_tb";
            this.maKhachHang_tb.ReadOnly = true;
            this.maKhachHang_tb.Size = new System.Drawing.Size(161, 20);
            this.maKhachHang_tb.TabIndex = 6;
            // 
            // hoTenKH_tb
            // 
            this.hoTenKH_tb.Location = new System.Drawing.Point(111, 55);
            this.hoTenKH_tb.Name = "hoTenKH_tb";
            this.hoTenKH_tb.ReadOnly = true;
            this.hoTenKH_tb.Size = new System.Drawing.Size(161, 20);
            this.hoTenKH_tb.TabIndex = 7;
            // 
            // diachi_tb
            // 
            this.diachi_tb.Location = new System.Drawing.Point(59, 87);
            this.diachi_tb.Name = "diachi_tb";
            this.diachi_tb.ReadOnly = true;
            this.diachi_tb.Size = new System.Drawing.Size(213, 20);
            this.diachi_tb.TabIndex = 8;
            // 
            // sdt_tb
            // 
            this.sdt_tb.Location = new System.Drawing.Point(111, 120);
            this.sdt_tb.Name = "sdt_tb";
            this.sdt_tb.ReadOnly = true;
            this.sdt_tb.Size = new System.Drawing.Size(161, 20);
            this.sdt_tb.TabIndex = 9;
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(62, 152);
            this.email_tb.Name = "email_tb";
            this.email_tb.ReadOnly = true;
            this.email_tb.Size = new System.Drawing.Size(210, 20);
            this.email_tb.TabIndex = 10;
            // 
            // tienno_tb
            // 
            this.tienno_tb.Location = new System.Drawing.Point(111, 185);
            this.tienno_tb.Name = "tienno_tb";
            this.tienno_tb.ReadOnly = true;
            this.tienno_tb.Size = new System.Drawing.Size(161, 20);
            this.tienno_tb.TabIndex = 11;
            // 
            // thoat_button
            // 
            this.thoat_button.Location = new System.Drawing.Point(158, 226);
            this.thoat_button.Name = "thoat_button";
            this.thoat_button.Size = new System.Drawing.Size(75, 23);
            this.thoat_button.TabIndex = 12;
            this.thoat_button.Text = "Thoát";
            this.thoat_button.UseVisualStyleBackColor = true;
            this.thoat_button.Click += new System.EventHandler(this.thoat_button_Click);
            // 
            // FormThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.thoat_button);
            this.Controls.Add(this.tienno_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.sdt_tb);
            this.Controls.Add(this.diachi_tb);
            this.Controls.Add(this.hoTenKH_tb);
            this.Controls.Add(this.maKhachHang_tb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThongTinKhachHang";
            this.Text = "Thông tin khách hàng";
            this.Load += new System.EventHandler(this.FormThongTinKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maKhachHang_tb;
        private System.Windows.Forms.TextBox hoTenKH_tb;
        private System.Windows.Forms.TextBox diachi_tb;
        private System.Windows.Forms.TextBox sdt_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox tienno_tb;
        private System.Windows.Forms.Button thoat_button;
    }
}