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
    public partial class frm_DanhSachLH : Form
    {
        BLL.BL_ListLopHoc bl;
        public frm_DanhSachLH()
        {
            InitializeComponent();
            bl = new BLL.BL_ListLopHoc(this);
        }

        private void frm_DanhSachLH_Load(object sender, EventArgs e)
        {
            bl.loadBang();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl.loadBang();
        }
    }
}
