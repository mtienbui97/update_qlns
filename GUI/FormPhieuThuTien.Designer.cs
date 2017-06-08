namespace GUI
{
    partial class FormPhieuThuTien
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.maphieu_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.makh_tb = new System.Windows.Forms.TextBox();
            this.ten_tb = new System.Windows.Forms.TextBox();
            this.diachi_tb = new System.Windows.Forms.TextBox();
            this.sdt_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.sotienthu_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lapphieu_button = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày lập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số tiền thu";
            // 
            // maphieu_tb
            // 
            this.maphieu_tb.Location = new System.Drawing.Point(145, 40);
            this.maphieu_tb.Name = "maphieu_tb";
            this.maphieu_tb.ReadOnly = true;
            this.maphieu_tb.Size = new System.Drawing.Size(200, 20);
            this.maphieu_tb.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // makh_tb
            // 
            this.makh_tb.Location = new System.Drawing.Point(145, 101);
            this.makh_tb.MaxLength = 6;
            this.makh_tb.Name = "makh_tb";
            this.makh_tb.Size = new System.Drawing.Size(200, 20);
            this.makh_tb.TabIndex = 11;
            this.makh_tb.TextChanged += new System.EventHandler(this.makh_tb_TextChanged);
            // 
            // ten_tb
            // 
            this.ten_tb.Location = new System.Drawing.Point(145, 132);
            this.ten_tb.Name = "ten_tb";
            this.ten_tb.ReadOnly = true;
            this.ten_tb.Size = new System.Drawing.Size(200, 20);
            this.ten_tb.TabIndex = 12;
            // 
            // diachi_tb
            // 
            this.diachi_tb.Location = new System.Drawing.Point(145, 161);
            this.diachi_tb.Name = "diachi_tb";
            this.diachi_tb.ReadOnly = true;
            this.diachi_tb.Size = new System.Drawing.Size(200, 20);
            this.diachi_tb.TabIndex = 13;
            // 
            // sdt_tb
            // 
            this.sdt_tb.Location = new System.Drawing.Point(145, 190);
            this.sdt_tb.Name = "sdt_tb";
            this.sdt_tb.ReadOnly = true;
            this.sdt_tb.Size = new System.Drawing.Size(200, 20);
            this.sdt_tb.TabIndex = 14;
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(145, 222);
            this.email_tb.Name = "email_tb";
            this.email_tb.ReadOnly = true;
            this.email_tb.Size = new System.Drawing.Size(200, 20);
            this.email_tb.TabIndex = 15;
            // 
            // sotienthu_tb
            // 
            this.sotienthu_tb.Location = new System.Drawing.Point(145, 253);
            this.sotienthu_tb.Name = "sotienthu_tb";
            this.sotienthu_tb.Size = new System.Drawing.Size(200, 20);
            this.sotienthu_tb.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(113, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "PHIẾU THU TIỀN";
            // 
            // lapphieu_button
            // 
            this.lapphieu_button.Location = new System.Drawing.Point(80, 297);
            this.lapphieu_button.Name = "lapphieu_button";
            this.lapphieu_button.Size = new System.Drawing.Size(75, 23);
            this.lapphieu_button.TabIndex = 18;
            this.lapphieu_button.Text = "Lập phiếu";
            this.lapphieu_button.UseVisualStyleBackColor = true;
            this.lapphieu_button.Click += new System.EventHandler(this.lapphieu_button_Click);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(224, 297);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 19;
            this.refresh.Text = "Clear";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // FormPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 343);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.lapphieu_button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sotienthu_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.sdt_tb);
            this.Controls.Add(this.diachi_tb);
            this.Controls.Add(this.ten_tb);
            this.Controls.Add(this.makh_tb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maphieu_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPhieuThuTien";
            this.Text = "Phiếu thu tiền";
            this.Load += new System.EventHandler(this.FormPhieuThuTien_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maphieu_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox makh_tb;
        private System.Windows.Forms.TextBox ten_tb;
        private System.Windows.Forms.TextBox diachi_tb;
        private System.Windows.Forms.TextBox sdt_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox sotienthu_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button lapphieu_button;
        private System.Windows.Forms.Button refresh;
    }
}