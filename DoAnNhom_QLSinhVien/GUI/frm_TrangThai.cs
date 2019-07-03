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
    public partial class frm_TrangThai : Form
    {
        BLL.BL_TrangThai bl;
        public frm_TrangThai()
        {
            InitializeComponent();
            bl = new BLL.BL_TrangThai(this);
        }

        private void frm_TrangThai_Load(object sender, EventArgs e)
        {
            txt_Nam.Text = bl.demNam().ToString();
            txt_Nu.Text = bl.demNu().ToString();
        }
    }
}
