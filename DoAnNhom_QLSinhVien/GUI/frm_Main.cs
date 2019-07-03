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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_ListSV"))
            {
                frm_ListSV frm = new frm_ListSV();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_ListSV");
            }
            
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_AddSV"))
            {
                frm_AddSV frm = new frm_AddSV();
                frm.MdiParent = this;
                frm.Show();
            } else
            {
                activeChilForm("frm_AddSV");
            }
            
        }

        private void trạngTháiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_TrangThai"))
            {
                frm_TrangThai frm = new frm_TrangThai();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_TrangThai");
            }
            
        }

        private void sửaXóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_UpdateDelete"))
            {
                frm_UpdateDelete frm = new frm_UpdateDelete();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_UpdateDelete");
            }
            
        }

        private void thêmMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_AddMonHoc"))
            {
                frm_AddMonHoc frm = new frm_AddMonHoc();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_AddMonHoc");
            }
            
        }

        private void xóaMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_EditMonHoc"))
            {
                frm_EditMonHoc frm = new frm_EditMonHoc();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_EditMonHoc");
            }
     
        }

        private void danhSaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_ListMonHoc"))
            {
                frm_ListMonHoc frm = new frm_ListMonHoc();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_ListMonHoc");
            }
          
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_XoaMonHoc"))
            {
                frm_XoaMonHoc frm = new frm_XoaMonHoc();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_XoaMonHoc");
            }

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn đăng xuất không?", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if(dt == DialogResult.Yes)
            {
                this.Hide();
                frm_Login frm = new frm_Login();
                frm.Show();
            }
            
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_DangKy"))
            {
                frm_DangKy frm = new frm_DangKy();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_DangKy");
            }
            
        }

        private void thêmĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_AddDiem"))
            {
                frm_AddDiem frm = new frm_AddDiem();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_AddDiem");
            }
           
        }

        private void quảnLíĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_QuanLiDiem"))
            {
                frm_QuanLiDiem frm = new frm_QuanLiDiem();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_QuanLiDiem");
            }
            
        }

        private void quanLiMHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_QuanLiDiem"))
            {
                frm_QuanLiDiem frm = new frm_QuanLiDiem();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_QuanLiDiem");
            }
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn có muốn đăng xuất không?", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if (dt == DialogResult.Yes)
            {
                this.Hide();
                frm_Login frm = new frm_Login();
    
                frm.Show();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_AddSV"))
            {
                frm_AddSV frm = new frm_AddSV();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_AddSV");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_TrangThai"))
            {
                frm_TrangThai frm = new frm_TrangThai();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_TrangThai");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_ListMonHoc"))
            {
                frm_ListMonHoc frm = new frm_ListMonHoc();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_ListMonHoc");
            }
        }

        private bool checkExitsForm(string name)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void activeChilForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void danhSáchLHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!checkExitsForm("frm_DanhSachLH"))
            {
                frm_DanhSachLH frm = new frm_DanhSachLH();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                activeChilForm("frm_DanhSachLH");
            }
        }
    }
}
