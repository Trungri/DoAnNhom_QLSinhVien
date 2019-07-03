namespace DoAnNhom_QLSinhVien.GUI
{
    partial class frm_EditMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EditMonHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_TenMon = new System.Windows.Forms.ComboBox();
            this.txt_MoTa = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.txt_SoTinChi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tín chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả";
            // 
            // cb_TenMon
            // 
            this.cb_TenMon.FormattingEnabled = true;
            this.cb_TenMon.Location = new System.Drawing.Point(102, 52);
            this.cb_TenMon.Name = "cb_TenMon";
            this.cb_TenMon.Size = new System.Drawing.Size(153, 21);
            this.cb_TenMon.TabIndex = 3;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(102, 143);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(153, 20);
            this.txt_MoTa.TabIndex = 5;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(90, 216);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(138, 42);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_SoTinChi
            // 
            this.txt_SoTinChi.Location = new System.Drawing.Point(102, 99);
            this.txt_SoTinChi.Name = "txt_SoTinChi";
            this.txt_SoTinChi.Size = new System.Drawing.Size(73, 20);
            this.txt_SoTinChi.TabIndex = 7;
            // 
            // frm_EditMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 310);
            this.Controls.Add(this.txt_SoTinChi);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.cb_TenMon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EditMonHoc";
            this.Text = "frm_EditMonHoc";
            this.Load += new System.EventHandler(this.frm_EditMonHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cb_TenMon;
        public System.Windows.Forms.TextBox txt_MoTa;
        public System.Windows.Forms.Button btn_Sua;
        public System.Windows.Forms.TextBox txt_SoTinChi;
    }
}