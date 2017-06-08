namespace GUI
{
    partial class FormLapPhieuNhapSach
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
            this.MaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NgayNhap = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SoLuongNhapItNhat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SoLuongTonToiDaTruocNhap = new System.Windows.Forms.TextBox();
            this.ThemSach = new System.Windows.Forms.Button();
            this.DataGridChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.XoaSach = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // MaPhieuNhap
            // 
            this.MaPhieuNhap.Location = new System.Drawing.Point(207, 52);
            this.MaPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaPhieuNhap.Name = "MaPhieuNhap";
            this.MaPhieuNhap.ReadOnly = true;
            this.MaPhieuNhap.Size = new System.Drawing.Size(148, 26);
            this.MaPhieuNhap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày nhập";
            // 
            // NgayNhap
            // 
            this.NgayNhap.Location = new System.Drawing.Point(207, 102);
            this.NgayNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.Size = new System.Drawing.Size(298, 26);
            this.NgayNhap.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(915, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lập phiếu nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số lượng nhập ít nhất";
            // 
            // SoLuongNhapItNhat
            // 
            this.SoLuongNhapItNhat.Location = new System.Drawing.Point(968, 52);
            this.SoLuongNhapItNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SoLuongNhapItNhat.Name = "SoLuongNhapItNhat";
            this.SoLuongNhapItNhat.ReadOnly = true;
            this.SoLuongNhapItNhat.Size = new System.Drawing.Size(148, 26);
            this.SoLuongNhapItNhat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số lượng tồn tối đa trước khi nhập";
            // 
            // SoLuongTonToiDaTruocNhap
            // 
            this.SoLuongTonToiDaTruocNhap.Location = new System.Drawing.Point(968, 106);
            this.SoLuongTonToiDaTruocNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SoLuongTonToiDaTruocNhap.Name = "SoLuongTonToiDaTruocNhap";
            this.SoLuongTonToiDaTruocNhap.ReadOnly = true;
            this.SoLuongTonToiDaTruocNhap.Size = new System.Drawing.Size(148, 26);
            this.SoLuongTonToiDaTruocNhap.TabIndex = 9;
            // 
            // ThemSach
            // 
            this.ThemSach.Location = new System.Drawing.Point(665, 451);
            this.ThemSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ThemSach.Name = "ThemSach";
            this.ThemSach.Size = new System.Drawing.Size(201, 35);
            this.ThemSach.TabIndex = 11;
            this.ThemSach.Text = "Thêm sách";
            this.ThemSach.UseVisualStyleBackColor = true;
            this.ThemSach.Click += new System.EventHandler(this.ThemSach_Click);
            // 
            // DataGridChiTietPhieuNhap
            // 
            this.DataGridChiTietPhieuNhap.AllowUserToAddRows = false;
            this.DataGridChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.DataGridChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridChiTietPhieuNhap.Location = new System.Drawing.Point(18, 178);
            this.DataGridChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridChiTietPhieuNhap.Name = "DataGridChiTietPhieuNhap";
            this.DataGridChiTietPhieuNhap.ReadOnly = true;
            this.DataGridChiTietPhieuNhap.Size = new System.Drawing.Size(1114, 231);
            this.DataGridChiTietPhieuNhap.TabIndex = 5;
            // 
            // XoaSach
            // 
            this.XoaSach.Location = new System.Drawing.Point(413, 451);
            this.XoaSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.XoaSach.Name = "XoaSach";
            this.XoaSach.Size = new System.Drawing.Size(201, 35);
            this.XoaSach.TabIndex = 12;
            this.XoaSach.Text = "Xóa sách";
            this.XoaSach.UseVisualStyleBackColor = true;
            this.XoaSach.Click += new System.EventHandler(this.XoaSach_Click);
            // 
            // FormLapPhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 505);
            this.Controls.Add(this.XoaSach);
            this.Controls.Add(this.ThemSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SoLuongTonToiDaTruocNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SoLuongNhapItNhat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGridChiTietPhieuNhap);
            this.Controls.Add(this.NgayNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaPhieuNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLapPhieuNhapSach";
            this.Text = "Lập phiếu nhập sách";
            this.Load += new System.EventHandler(this.FormLapPhieuNhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaPhieuNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker NgayNhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SoLuongNhapItNhat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SoLuongTonToiDaTruocNhap;
        private System.Windows.Forms.Button ThemSach;
        private System.Windows.Forms.DataGridView DataGridChiTietPhieuNhap;
        private System.Windows.Forms.Button XoaSach;
    }
}

