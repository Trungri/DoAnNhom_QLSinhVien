using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
    class BL_ListMonHoc
    {
        GUI.frm_ListMonHoc frm;
        DAL.DA_ListMonHoc da;
        public BL_ListMonHoc(GUI.frm_ListMonHoc f)
        {
            da = new DAL.DA_ListMonHoc();
            frm = f;
        }

        public void loadBang()
        {
            frm.dataGridView1.DataSource = da.loadBang();
        }
    }
}
