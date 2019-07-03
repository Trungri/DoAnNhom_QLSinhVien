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
    public partial class frm_DangKy : Form
    {
        BLL.BL_DangKy bl;
        public frm_DangKy()
        {
            InitializeComponent();
            bl = new BLL.BL_DangKy(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txt_Pass.Text.Equals(txt_PassNhapLai.Text))
            {
                int ketQua = bl.DangKy();
                if (ketQua > 0)
                {
                    MessageBox.Show("Đăng ký thành công", "THÔNG BÁO");
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại", "THÔNG BÁO");
                }

            } else if (txt_TaiKhoan.Text.Equals(""))
            {
                MessageBox.Show("Tài khoản không được để trống", "THÔNG BÁO");
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp", "THÔNG BÁO");
            }

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
