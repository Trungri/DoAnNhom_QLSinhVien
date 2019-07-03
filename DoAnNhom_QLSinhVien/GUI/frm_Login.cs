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
    public partial class frm_Login : Form
    {
        BLL.BL_Login bl_login;

        public frm_Login()
        {
            InitializeComponent();
            bl_login = new BLL.BL_Login(this);
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            
            int ketQua = bl_login.Login();
            if (ketQua == 1)
            {
                this.Hide();
                frm_Main form = new frm_Main();
                form.Show();
                
            }
            else
            {
                MessageBox.Show("Dang nhap That Bai", "THÔNG BÁO");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn thoát không?", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if(dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Text = "";
            txt_TaiKhoan.Text = "";
        }
    }
}
