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
    public partial class frm_AddMonHoc : Form
    {
        BLL.BL_MonHoc bl;
        public frm_AddMonHoc()
        {
            InitializeComponent();
            bl = new BLL.BL_MonHoc(this);
        }

        private void btn_Them_Click(object sender, EventArgs e)
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
    }
}
