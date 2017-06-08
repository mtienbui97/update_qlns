namespace GUI.KHACHHANG
{
    partial class FormImportKhachHang
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.import_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.hoten_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoten_col,
            this.diachi_col,
            this.sdt_col,
            this.email_col});
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 302);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // import_button
            // 
            this.import_button.Location = new System.Drawing.Point(493, 320);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(75, 23);
            this.import_button.TabIndex = 13;
            this.import_button.Text = "Thêm";
            this.import_button.UseVisualStyleBackColor = true;
            this.import_button.Click += new System.EventHandler(this.import_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(109, 320);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "Xóa";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(15, 320);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 23);
            this.update_button.TabIndex = 15;
            this.update_button.Text = "Sửa";
            this.update_button.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(583, 320);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // hoten_col
            // 
            this.hoten_col.HeaderText = "Họ Tên";
            this.hoten_col.Name = "hoten_col";
            // 
            // diachi_col
            // 
            this.diachi_col.HeaderText = "Địa chỉ";
            this.diachi_col.Name = "diachi_col";
            // 
            // sdt_col
            // 
            this.sdt_col.HeaderText = "SĐT";
            this.sdt_col.Name = "sdt_col";
            // 
            // email_col
            // 
            this.email_col.HeaderText = "Email";
            this.email_col.Name = "email_col";
            // 
            // FormImportKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 350);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.import_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Name = "FormImportKhachHang";
            this.Text = "FormImportKhachHang";
            this.Load += new System.EventHandler(this.FormImportKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_col;
    }
}