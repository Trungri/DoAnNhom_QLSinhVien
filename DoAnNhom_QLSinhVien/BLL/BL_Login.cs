using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
   
    class BL_Login
    {
        GUI.frm_Login frm;
        DAL.DA_Login da;
        public BL_Login(GUI.frm_Login f)
        {
            da = new DAL.DA_Login();
            frm = f;
        }

        public int Login()
        {
            return da.Login(frm.txt_TaiKhoan.Text, frm.txt_MatKhau.Text);
        }
    }
}
