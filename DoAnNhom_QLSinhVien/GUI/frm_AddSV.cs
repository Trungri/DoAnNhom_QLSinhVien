using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhom_QLSinhVien.GUI
{
    public partial class frm_AddSV : Form
    {
        BLL.BL_SinhVien bl;
        GUI.frm_ListSV frm;
        public frm_AddSV()
        {
            InitializeComponent();
            bl = new BLL.BL_SinhVien(this);
            frm = new GUI.frm_ListSV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kq = bl.Them();
            if (kq > 0)
            {
                MessageBox.Show("THEM Thanh Cong", "THÔNG BÁO");
           
            }
            else
            {
                MessageBox.Show("Them That Bai", "THÔNG BÁO");
            }
        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không?", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if (dt == DialogResult.Yes)
            {
                this.Hide();

            }
                
        }

        private void frm_AddSV_Load(object sender, EventArgs e)
        {
            bl.loadCombo();
        }
    }
}
