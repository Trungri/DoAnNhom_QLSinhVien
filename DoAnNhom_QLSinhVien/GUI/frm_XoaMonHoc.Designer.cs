namespace DoAnNhom_QLSinhVien.GUI
{
    partial class frm_XoaMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_XoaMonHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.cb_MaMon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã môn học";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(119, 81);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(99, 47);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_MaMon
            // 
            this.cb_MaMon.FormattingEnabled = true;
            this.cb_MaMon.Location = new System.Drawing.Point(136, 40);
            this.cb_MaMon.Name = "cb_MaMon";
            this.cb_MaMon.Size = new System.Drawing.Size(167, 21);
            this.cb_MaMon.TabIndex = 3;
            // 
            // frm_XoaMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 150);
            this.Controls.Add(this.cb_MaMon);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_XoaMonHoc";
            this.Text = "frm_XoaMonHoc";
            this.Load += new System.EventHandler(this.frm_XoaMonHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_Xoa;
        public System.Windows.Forms.ComboBox cb_MaMon;
    }
}