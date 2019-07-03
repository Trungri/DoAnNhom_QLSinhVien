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
    public partial class frm_AddDiem : Form
    {
        BLL.BL_AddDiem bl;
        public frm_AddDiem()
        {
            InitializeComponent();
            bl = new BLL.BL_AddDiem(this);
        }

        private void frm_AddDiem_Load(object sender, EventArgs e)
        {
            bl.loadCombo();
            bl.loadCombo_SV();
            bl.loadBang();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int kq = bl.Them();
            if (kq > 0)
            {
                MessageBox.Show("THÊM thành công", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("THÊM thất bại", "THÔNG BÁO");
            }
            bl.loadBang();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không?", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if (dt == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
