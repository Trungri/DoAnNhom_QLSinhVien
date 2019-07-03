using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
    class BL_SuaMonHoc
    {
        DAL.DA_SuaMonHoc da;
        GUI.frm_EditMonHoc frm;
        public BL_SuaMonHoc(GUI.frm_EditMonHoc f)
        {
            da = new DAL.DA_SuaMonHoc();
            frm = f;
        }

        public void loadCombo()
        {
            frm.cb_TenMon.DataSource = da.loadCombo();
            frm.cb_TenMon.DisplayMember = "TenMon";
            frm.cb_TenMon.ValueMember = "MaMon";
        }

        public int Sua()
        {
            return da.Sua(frm.cb_TenMon.Text ,Int32.Parse(frm.txt_SoTinChi.Text), frm.txt_MoTa.Text);
        }

    }
}
