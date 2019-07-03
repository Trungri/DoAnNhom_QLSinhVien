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
    public partial class frm_EditMonHoc : Form
    {
        BLL.BL_SuaMonHoc bl;
        public frm_EditMonHoc()
        {
            InitializeComponent();
            bl = new BLL.BL_SuaMonHoc(this);
        }

        private void frm_EditMonHoc_Load(object sender, EventArgs e)
        {
            bl.loadCombo();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int kq = bl.Sua();
            if (kq > 0)
            {
                MessageBox.Show("SUA Thanh Cong", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("SUA That Bai", "THÔNG BÁO");
            }
        }
    }
}
