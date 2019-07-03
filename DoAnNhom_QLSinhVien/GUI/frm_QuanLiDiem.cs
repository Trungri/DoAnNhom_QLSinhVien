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
    public partial class frm_QuanLiDiem : Form
    {
        BLL.BL_QLDiem bl;
        public frm_QuanLiDiem()
        {
            InitializeComponent();
            bl = new BLL.BL_QLDiem(this);
        }

        private void frm_QuanLiDiem_Load(object sender, EventArgs e)
        {
            bl.loadCombo();
            bl.loadBang();
        }

        private void cb_IDSV_Click(object sender, EventArgs e)
        {
            
        }

        private void cb_IDSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            bl.loadData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl.loadBang();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bl.loadBang_SVDat();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bl.loadBang_SVKhongDat();
        }
    }
}
