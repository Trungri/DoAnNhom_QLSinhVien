using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
    class BL_XoaMonHoc
    {
        DAL.DA_XoaMonHoc da;
        GUI.frm_XoaMonHoc frm;
        public BL_XoaMonHoc(GUI.frm_XoaMonHoc f)
        {
            da = new DAL.DA_XoaMonHoc();
            frm = f;
        }

        public void loadCombo()
        {
            frm.cb_MaMon.DataSource = da.loadCombo();
            frm.cb_MaMon.DisplayMember = "MaMon";
            frm.cb_MaMon.ValueMember = "TenMon";
        }

        public int Xoa()
        {
            return da.Xoa(frm.cb_MaMon.Text);
        }
    }
}
