namespace DoAnNhom_QLSinhVien.GUI
{
    partial class frm_AddMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddMonHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaMon = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TenMon = new System.Windows.Forms.TextBox();
            this.txt_SoTinChi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tín chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả";
            // 
            // txt_MaMon
            // 
            this.txt_MaMon.Location = new System.Drawing.Point(110, 31);
            this.txt_MaMon.Name = "txt_MaMon";
            this.txt_MaMon.Size = new System.Drawing.Size(155, 20);
            this.txt_MaMon.TabIndex = 3;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(110, 152);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(155, 20);
            this.txt_MoTa.TabIndex = 4;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(56, 197);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(174, 38);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "THÊM";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên môn";
            // 
            // txt_TenMon
            // 
            this.txt_TenMon.Location = new System.Drawing.Point(110, 66);
            this.txt_TenMon.Name = "txt_TenMon";
            this.txt_TenMon.Size = new System.Drawing.Size(155, 20);
            this.txt_TenMon.TabIndex = 8;
            // 
            // txt_SoTinChi
            // 
            this.txt_SoTinChi.Location = new System.Drawing.Point(110, 109);
            this.txt_SoTinChi.Name = "txt_SoTinChi";
            this.txt_SoTinChi.Size = new System.Drawing.Size(71, 20);
            this.txt_SoTinChi.TabIndex = 9;
            // 
            // frm_AddMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 265);
            this.Controls.Add(this.txt_SoTinChi);
            this.Controls.Add(this.txt_TenMon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.txt_MaMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddMonHoc";
            this.Text = "frm_AddMonHoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_MaMon;
        public System.Windows.Forms.TextBox txt_MoTa;
        public System.Windows.Forms.Button btn_Them;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_TenMon;
        public System.Windows.Forms.TextBox txt_SoTinChi;
    }
}