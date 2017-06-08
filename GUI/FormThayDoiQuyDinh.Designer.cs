namespace GUI
{
    partial class FormThayDoiQuyDinh
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
            this.sudungquidinh = new System.Windows.Forms.CheckBox();
            this.slNhap_tb = new System.Windows.Forms.TextBox();
            this.tienNo_tb = new System.Windows.Forms.TextBox();
            this.slTonSauBan_tb = new System.Windows.Forms.TextBox();
            this.slTonTruocNhap_tb = new System.Windows.Forms.TextBox();
            this.capnhat_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SỐ LƯỢNG NHẬP TỐI THIỂU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SỐ LƯỢNG TỒN TỐI ĐA TRƯỚC NHẬP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SỐ LƯỢNG TỒN TỐI THIỂU SAU KHI BÁN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "TIỀN NỢ TỐI ĐA";
            // 
            // sudungquidinh
            // 
            this.sudungquidinh.AutoSize = true;
            this.sudungquidinh.Location = new System.Drawing.Point(15, 176);
            this.sudungquidinh.Name = "sudungquidinh";
            this.sudungquidinh.Size = new System.Drawing.Size(141, 17);
            this.sudungquidinh.TabIndex = 5;
            this.sudungquidinh.Text = "SỬ DỤNG QUY ĐỊNH 4";
            this.sudungquidinh.UseVisualStyleBackColor = true;
            // 
            // slNhap_tb
            // 
            this.slNhap_tb.Location = new System.Drawing.Point(249, 32);
            this.slNhap_tb.Name = "slNhap_tb";
            this.slNhap_tb.Size = new System.Drawing.Size(244, 20);
            this.slNhap_tb.TabIndex = 6;
            // 
            // tienNo_tb
            // 
            this.tienNo_tb.Location = new System.Drawing.Point(249, 103);
            this.tienNo_tb.Name = "tienNo_tb";
            this.tienNo_tb.Size = new System.Drawing.Size(244, 20);
            this.tienNo_tb.TabIndex = 7;
            // 
            // slTonSauBan_tb
            // 
            this.slTonSauBan_tb.Location = new System.Drawing.Point(249, 139);
            this.slTonSauBan_tb.Name = "slTonSauBan_tb";
            this.slTonSauBan_tb.Size = new System.Drawing.Size(244, 20);
            this.slTonSauBan_tb.TabIndex = 8;
            // 
            // slTonTruocNhap_tb
            // 
            this.slTonTruocNhap_tb.Location = new System.Drawing.Point(249, 66);
            this.slTonTruocNhap_tb.Name = "slTonTruocNhap_tb";
            this.slTonTruocNhap_tb.Size = new System.Drawing.Size(244, 20);
            this.slTonTruocNhap_tb.TabIndex = 9;
            // 
            // capnhat_bt
            // 
            this.capnhat_bt.Location = new System.Drawing.Point(382, 195);
            this.capnhat_bt.Name = "capnhat_bt";
            this.capnhat_bt.Size = new System.Drawing.Size(111, 23);
            this.capnhat_bt.TabIndex = 10;
            this.capnhat_bt.Text = "Cập nhật";
            this.capnhat_bt.UseVisualStyleBackColor = true;
            this.capnhat_bt.Click += new System.EventHandler(this.capnhat_bt_Click);
            // 
            // FormThayDoiQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 235);
            this.Controls.Add(this.capnhat_bt);
            this.Controls.Add(this.slTonTruocNhap_tb);
            this.Controls.Add(this.slTonSauBan_tb);
            this.Controls.Add(this.tienNo_tb);
            this.Controls.Add(this.slNhap_tb);
            this.Controls.Add(this.sudungquidinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThayDoiQuyDinh";
            this.Text = "Thay đổi quy định";
            this.Load += new System.EventHandler(this.FormThayDoiQuyDinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox sudungquidinh;
        private System.Windows.Forms.TextBox slNhap_tb;
        private System.Windows.Forms.TextBox tienNo_tb;
        private System.Windows.Forms.TextBox slTonSauBan_tb;
        private System.Windows.Forms.TextBox slTonTruocNhap_tb;
        private System.Windows.Forms.Button capnhat_bt;
    }
}