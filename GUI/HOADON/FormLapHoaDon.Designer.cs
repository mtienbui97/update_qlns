namespace GUI
{
    partial class FormLapHoaDon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.maHoaDon_tb = new System.Windows.Forms.TextBox();
            this.maKhachHang_tb = new System.Windows.Forms.TextBox();
            this.slTonToiThieuSauBan_tb = new System.Windows.Forms.TextBox();
            this.tongTien_tb = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.xem_button = new System.Windows.Forms.Button();
            this.themsach_button = new System.Windows.Forms.Button();
            this.lapHoadon_button = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày lập hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng tồn tối thiểu sau bán";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 183);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tổng tiền";
            // 
            // maHoaDon_tb
            // 
            this.maHoaDon_tb.Location = new System.Drawing.Point(108, 16);
            this.maHoaDon_tb.Name = "maHoaDon_tb";
            this.maHoaDon_tb.Size = new System.Drawing.Size(200, 20);
            this.maHoaDon_tb.TabIndex = 6;
            // 
            // maKhachHang_tb
            // 
            this.maKhachHang_tb.Location = new System.Drawing.Point(108, 40);
            this.maKhachHang_tb.Name = "maKhachHang_tb";
            this.maKhachHang_tb.Size = new System.Drawing.Size(200, 20);
            this.maKhachHang_tb.TabIndex = 7;
            this.maKhachHang_tb.TextChanged += new System.EventHandler(this.maKhachHang_tb_TextChanged);
            // 
            // slTonToiThieuSauBan_tb
            // 
            this.slTonToiThieuSauBan_tb.Location = new System.Drawing.Point(521, 16);
            this.slTonToiThieuSauBan_tb.Name = "slTonToiThieuSauBan_tb";
            this.slTonToiThieuSauBan_tb.Size = new System.Drawing.Size(137, 20);
            this.slTonToiThieuSauBan_tb.TabIndex = 9;
            // 
            // tongTien_tb
            // 
            this.tongTien_tb.Location = new System.Drawing.Point(108, 326);
            this.tongTien_tb.Name = "tongTien_tb";
            this.tongTien_tb.ReadOnly = true;
            this.tongTien_tb.Size = new System.Drawing.Size(200, 20);
            this.tongTien_tb.TabIndex = 10;
            this.tongTien_tb.Text = "0";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // xem_button
            // 
            this.xem_button.Location = new System.Drawing.Point(314, 40);
            this.xem_button.Name = "xem_button";
            this.xem_button.Size = new System.Drawing.Size(53, 20);
            this.xem_button.TabIndex = 12;
            this.xem_button.Text = "Kiểm tra";
            this.xem_button.UseVisualStyleBackColor = true;
            this.xem_button.Click += new System.EventHandler(this.xem_button_Click);
            // 
            // themsach_button
            // 
            this.themsach_button.Location = new System.Drawing.Point(593, 96);
            this.themsach_button.Name = "themsach_button";
            this.themsach_button.Size = new System.Drawing.Size(75, 23);
            this.themsach_button.TabIndex = 13;
            this.themsach_button.Text = "Thêm sách";
            this.themsach_button.UseVisualStyleBackColor = true;
            this.themsach_button.Click += new System.EventHandler(this.themsach_button_Click);
            // 
            // lapHoadon_button
            // 
            this.lapHoadon_button.Location = new System.Drawing.Point(557, 324);
            this.lapHoadon_button.Name = "lapHoadon_button";
            this.lapHoadon_button.Size = new System.Drawing.Size(111, 23);
            this.lapHoadon_button.TabIndex = 15;
            this.lapHoadon_button.Text = "Lập hóa đơn";
            this.lapHoadon_button.UseVisualStyleBackColor = true;
            this.lapHoadon_button.Click += new System.EventHandler(this.lapHoadon_button_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(512, 96);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 16;
            this.delete.Text = "Xóa sách";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // FormLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 365);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.lapHoadon_button);
            this.Controls.Add(this.themsach_button);
            this.Controls.Add(this.xem_button);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tongTien_tb);
            this.Controls.Add(this.slTonToiThieuSauBan_tb);
            this.Controls.Add(this.maKhachHang_tb);
            this.Controls.Add(this.maHoaDon_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLapHoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.FormLapHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maHoaDon_tb;
        private System.Windows.Forms.TextBox maKhachHang_tb;
        private System.Windows.Forms.TextBox slTonToiThieuSauBan_tb;
        private System.Windows.Forms.TextBox tongTien_tb;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button xem_button;
        private System.Windows.Forms.Button themsach_button;
        private System.Windows.Forms.Button lapHoadon_button;
        private System.Windows.Forms.Button delete;
    }
}