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
    public partial class frm_XoaMonHoc : Form
    {
        BLL.BL_XoaMonHoc bl;
        public frm_XoaMonHoc()
        {
            InitializeComponent();
            bl = new BLL.BL_XoaMonHoc(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kq = bl.Xoa();
            if (kq > 0)
            {
                MessageBox.Show("XÓA Thành Công", "THÔNG BÁO");
                bl.loadCombo();
            }
            else
            {
                MessageBox.Show("XÓA Thất Bại", "THÔNG BÁO");
            }
        }

        private void frm_XoaMonHoc_Load(object sender, EventArgs e)
        {
            bl.loadCombo();
        }
    }
}
