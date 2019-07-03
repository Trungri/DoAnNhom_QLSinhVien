using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
    class BL_MonHoc
    {
        GUI.frm_AddMonHoc frm;
        DAL.DA_MonHoc da;
        public BL_MonHoc(GUI.frm_AddMonHoc f)
        {
            da = new DAL.DA_MonHoc();
            frm = f;
        }

        public int Them()
        {
            return da.Them(frm.txt_MaMon.Text, frm.txt_TenMon.Text, Int32.Parse(frm.txt_SoTinChi.Text), frm.txt_MaMon.Text);
        }
    }
}
