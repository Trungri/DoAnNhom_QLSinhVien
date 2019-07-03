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
    public partial class frm_ListMonHoc : Form
    {
        BLL.BL_ListMonHoc bl;
        public frm_ListMonHoc()
        {
            InitializeComponent();
            bl = new BLL.BL_ListMonHoc(this);
        }

        private void frm_ListMonHoc_Load(object sender, EventArgs e)
        {
            bl.loadBang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl.loadBang();
        }
    }
}
