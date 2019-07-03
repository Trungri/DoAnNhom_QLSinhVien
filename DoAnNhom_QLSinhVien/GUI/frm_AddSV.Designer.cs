namespace DoAnNhom_QLSinhVien.GUI
{
    partial class frm_AddSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddSV));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_SoDT = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radio_Nam = new System.Windows.Forms.RadioButton();
            this.radio_Nu = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_MaLop = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm Mới SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số ĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa Chỉ";
            // 
            // btn_Them
            // 
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(86, 343);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(202, 43);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(130, 92);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(200, 20);
            this.txt_HoTen.TabIndex = 8;
            // 
            // txt_SoDT
            // 
            this.txt_SoDT.Location = new System.Drawing.Point(130, 212);
            this.txt_SoDT.Name = "txt_SoDT";
            this.txt_SoDT.Size = new System.Drawing.Size(200, 20);
            this.txt_SoDT.TabIndex = 9;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(130, 255);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(200, 23);
            this.txt_DiaChi.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // radio_Nam
            // 
            this.radio_Nam.AutoSize = true;
            this.radio_Nam.Location = new System.Drawing.Point(130, 171);
            this.radio_Nam.Name = "radio_Nam";
            this.radio_Nam.Size = new System.Drawing.Size(47, 17);
            this.radio_Nam.TabIndex = 12;
            this.radio_Nam.TabStop = true;
            this.radio_Nam.Text = "Nam";
            this.radio_Nam.UseVisualStyleBackColor = true;
            // 
            // radio_Nu
            // 
            this.radio_Nu.AutoSize = true;
            this.radio_Nu.Location = new System.Drawing.Point(221, 171);
            this.radio_Nu.Name = "radio_Nu";
            this.radio_Nu.Size = new System.Drawing.Size(39, 17);
            this.radio_Nu.TabIndex = 13;
            this.radio_Nu.TabStop = true;
            this.radio_Nu.Text = "Nu";
            this.radio_Nu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(130, 48);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(200, 20);
            this.txt_ID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mã lớp";
            // 
            // cb_MaLop
            // 
            this.cb_MaLop.FormattingEnabled = true;
            this.cb_MaLop.Location = new System.Drawing.Point(130, 305);
            this.cb_MaLop.Name = "cb_MaLop";
            this.cb_MaLop.Size = new System.Drawing.Size(121, 21);
            this.cb_MaLop.TabIndex = 17;
            // 
            // frm_AddSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 412);
            this.Controls.Add(this.cb_MaLop);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radio_Nu);
            this.Controls.Add(this.radio_Nam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_SoDT);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddSV";
            this.Text = "frm_AddSV";
            this.Load += new System.EventHandler(this.frm_AddSV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_Them;
        public System.Windows.Forms.TextBox txt_HoTen;
        public System.Windows.Forms.TextBox txt_SoDT;
        public System.Windows.Forms.TextBox txt_DiaChi;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.RadioButton radio_Nam;
        public System.Windows.Forms.RadioButton radio_Nu;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cb_MaLop;
    }
}