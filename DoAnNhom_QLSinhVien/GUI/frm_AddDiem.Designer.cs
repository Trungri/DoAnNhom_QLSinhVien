namespace DoAnNhom_QLSinhVien.GUI
{
    partial class frm_AddDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddDiem));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Diem = new System.Windows.Forms.TextBox();
            this.txt_GhiChu = new System.Windows.Forms.TextBox();
            this.cb_MonHoc = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Them = new System.Windows.Forms.Button();
            this.cb_IDSV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn Môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi Chú";
            // 
            // txt_Diem
            // 
            this.txt_Diem.Location = new System.Drawing.Point(147, 123);
            this.txt_Diem.Name = "txt_Diem";
            this.txt_Diem.Size = new System.Drawing.Size(100, 20);
            this.txt_Diem.TabIndex = 5;
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.Location = new System.Drawing.Point(147, 168);
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.Size = new System.Drawing.Size(159, 20);
            this.txt_GhiChu.TabIndex = 6;
            // 
            // cb_MonHoc
            // 
            this.cb_MonHoc.FormattingEnabled = true;
            this.cb_MonHoc.Location = new System.Drawing.Point(147, 79);
            this.cb_MonHoc.Name = "cb_MonHoc";
            this.cb_MonHoc.Size = new System.Drawing.Size(187, 21);
            this.cb_MonHoc.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(357, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 218);
            this.dataGridView1.TabIndex = 8;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(57, 221);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(223, 35);
            this.btn_Them.TabIndex = 9;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // cb_IDSV
            // 
            this.cb_IDSV.FormattingEnabled = true;
            this.cb_IDSV.Location = new System.Drawing.Point(147, 35);
            this.cb_IDSV.Name = "cb_IDSV";
            this.cb_IDSV.Size = new System.Drawing.Size(159, 21);
            this.cb_IDSV.TabIndex = 11;
            // 
            // frm_AddDiem
            // 
            this.AcceptButton = this.btn_Them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 301);
            this.Controls.Add(this.cb_IDSV);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_MonHoc);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.txt_Diem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddDiem";
            this.Text = "frm_AddDiem";
            this.Load += new System.EventHandler(this.frm_AddDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_Diem;
        public System.Windows.Forms.TextBox txt_GhiChu;
        public System.Windows.Forms.ComboBox cb_MonHoc;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button btn_Them;
        public System.Windows.Forms.ComboBox cb_IDSV;
    }
}