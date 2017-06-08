namespace GUI
{
    partial class FormDanhSachSach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masach_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongton_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masach_tb = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.masach_checkbox = new System.Windows.Forms.CheckBox();
            this.ten_checkbox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.theloai_checkbox = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tacgia_checkbox = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.soluongton_checkbox = new System.Windows.Forms.CheckBox();
            this.dongia_checkbox = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach_col,
            this.tensach_col,
            this.theloai_col,
            this.tacgia_col,
            this.dongia_col,
            this.soluongton_col});
            this.dataGridView1.Location = new System.Drawing.Point(31, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // masach_col
            // 
            this.masach_col.HeaderText = "Mã sách";
            this.masach_col.Name = "masach_col";
            // 
            // tensach_col
            // 
            this.tensach_col.HeaderText = "Tên sách";
            this.tensach_col.Name = "tensach_col";
            // 
            // theloai_col
            // 
            this.theloai_col.HeaderText = "Thể loại";
            this.theloai_col.Name = "theloai_col";
            // 
            // tacgia_col
            // 
            this.tacgia_col.HeaderText = "Tác giả";
            this.tacgia_col.Name = "tacgia_col";
            // 
            // dongia_col
            // 
            this.dongia_col.HeaderText = "Đơn giá";
            this.dongia_col.Name = "dongia_col";
            // 
            // soluongton_col
            // 
            this.soluongton_col.HeaderText = "Số lượng tồn";
            this.soluongton_col.Name = "soluongton_col";
            // 
            // masach_tb
            // 
            this.masach_tb.Location = new System.Drawing.Point(108, 26);
            this.masach_tb.Name = "masach_tb";
            this.masach_tb.Size = new System.Drawing.Size(96, 20);
            this.masach_tb.TabIndex = 1;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(615, 24);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(57, 48);
            this.search_button.TabIndex = 3;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(117, 87);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 5;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(31, 87);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(75, 23);
            this.del_button.TabIndex = 6;
            this.del_button.Text = "Delete";
            this.del_button.UseVisualStyleBackColor = true;
            // 
            // masach_checkbox
            // 
            this.masach_checkbox.AutoSize = true;
            this.masach_checkbox.Location = new System.Drawing.Point(31, 28);
            this.masach_checkbox.Name = "masach_checkbox";
            this.masach_checkbox.Size = new System.Drawing.Size(67, 17);
            this.masach_checkbox.TabIndex = 7;
            this.masach_checkbox.Text = "Mã sách";
            this.masach_checkbox.UseVisualStyleBackColor = true;
            this.masach_checkbox.CheckedChanged += new System.EventHandler(this.masach_checkbox_CheckedChanged);
            // 
            // ten_checkbox
            // 
            this.ten_checkbox.AutoSize = true;
            this.ten_checkbox.Location = new System.Drawing.Point(31, 54);
            this.ten_checkbox.Name = "ten_checkbox";
            this.ten_checkbox.Size = new System.Drawing.Size(71, 17);
            this.ten_checkbox.TabIndex = 9;
            this.ten_checkbox.Text = "Tên sách";
            this.ten_checkbox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 8;
            // 
            // theloai_checkbox
            // 
            this.theloai_checkbox.AutoSize = true;
            this.theloai_checkbox.Location = new System.Drawing.Point(226, 28);
            this.theloai_checkbox.Name = "theloai_checkbox";
            this.theloai_checkbox.Size = new System.Drawing.Size(64, 17);
            this.theloai_checkbox.TabIndex = 11;
            this.theloai_checkbox.Text = "Thể loại";
            this.theloai_checkbox.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(296, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(95, 20);
            this.textBox2.TabIndex = 10;
            // 
            // tacgia_checkbox
            // 
            this.tacgia_checkbox.AutoSize = true;
            this.tacgia_checkbox.Location = new System.Drawing.Point(226, 53);
            this.tacgia_checkbox.Name = "tacgia_checkbox";
            this.tacgia_checkbox.Size = new System.Drawing.Size(62, 17);
            this.tacgia_checkbox.TabIndex = 13;
            this.tacgia_checkbox.Text = "Tác giả";
            this.tacgia_checkbox.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(296, 50);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 20);
            this.textBox3.TabIndex = 12;
            // 
            // soluongton_checkbox
            // 
            this.soluongton_checkbox.AutoSize = true;
            this.soluongton_checkbox.Location = new System.Drawing.Point(412, 26);
            this.soluongton_checkbox.Name = "soluongton_checkbox";
            this.soluongton_checkbox.Size = new System.Drawing.Size(86, 17);
            this.soluongton_checkbox.TabIndex = 15;
            this.soluongton_checkbox.Text = "Số lượng tồn";
            this.soluongton_checkbox.UseVisualStyleBackColor = true;
            // 
            // dongia_checkbox
            // 
            this.dongia_checkbox.AutoSize = true;
            this.dongia_checkbox.Location = new System.Drawing.Point(412, 53);
            this.dongia_checkbox.Name = "dongia_checkbox";
            this.dongia_checkbox.Size = new System.Drawing.Size(63, 17);
            this.dongia_checkbox.TabIndex = 17;
            this.dongia_checkbox.Text = "Đơn giá";
            this.dongia_checkbox.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(504, 50);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(96, 20);
            this.textBox5.TabIndex = 16;
            // 
            // FormDanhSachSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 370);
            this.Controls.Add(this.dongia_checkbox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.soluongton_checkbox);
            this.Controls.Add(this.tacgia_checkbox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.theloai_checkbox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ten_checkbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.masach_checkbox);
            this.Controls.Add(this.del_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.masach_tb);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDanhSachSach";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Tra cứu sách";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongton_col;
        private System.Windows.Forms.TextBox masach_tb;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.CheckBox masach_checkbox;
        private System.Windows.Forms.CheckBox ten_checkbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox theloai_checkbox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox tacgia_checkbox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox soluongton_checkbox;
        private System.Windows.Forms.CheckBox dongia_checkbox;
        private System.Windows.Forms.TextBox textBox5;
    }
}