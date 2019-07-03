namespace DoAnNhom_QLSinhVien.GUI
{
    partial class frm_DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangKy));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.txt_PassNhapLai = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten Tai Khoan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mat khau";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhap lai Mat Khau";
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Location = new System.Drawing.Point(162, 62);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(162, 20);
            this.txt_TaiKhoan.TabIndex = 4;
            // 
            // txt_Pass
            // 
            this.txt_Pass.Location = new System.Drawing.Point(162, 99);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.Size = new System.Drawing.Size(162, 20);
            this.txt_Pass.TabIndex = 5;
            // 
            // txt_PassNhapLai
            // 
            this.txt_PassNhapLai.Location = new System.Drawing.Point(162, 131);
            this.txt_PassNhapLai.Name = "txt_PassNhapLai";
            this.txt_PassNhapLai.Size = new System.Drawing.Size(162, 20);
            this.txt_PassNhapLai.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đăng ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_DangKy
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 236);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_PassNhapLai);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_TaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_DangKy";
            this.Text = "frm_DangKy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_TaiKhoan;
        public System.Windows.Forms.TextBox txt_Pass;
        public System.Windows.Forms.TextBox txt_PassNhapLai;
        private System.Windows.Forms.Button button1;
    }
}