using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
    class BL_DangKy
    {
        GUI.frm_DangKy frm;
        DAL.DA_DangKy da;
        public BL_DangKy(GUI.frm_DangKy f)
        {
            da = new DAL.DA_DangKy();
            frm = f;
        }

        public int DangKy()
        {
            return da.DangKy(frm.txt_TaiKhoan.Text, frm.txt_Pass.Text);
        }
    }
}
