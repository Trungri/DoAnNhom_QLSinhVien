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
    public partial class frm_UpdateDelete : Form
    {
        BLL.BL_SV_updateDelete bl;
        public frm_UpdateDelete()
        {
            InitializeComponent();
            bl = new BLL.BL_SV_updateDelete(this);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            
            int kq = bl.Sua(); ;
            if (kq > 0)
            {
                MessageBox.Show("SỬA Thành Công", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("SỬA Thất Bại", "THÔNG BÁO");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int kq = bl.Xoa(); ;
            if (kq > 0)
            {
                MessageBox.Show("XÓA Thành Công", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("XÓA Thất Bại", "THÔNG BÁO");
            }
        }

        private void frm_UpdateDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
