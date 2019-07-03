using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
    class BL_ListSV
    {
        GUI.frm_ListSV frm;
        DAL.DA_ListSV da;
        public BL_ListSV(GUI.frm_ListSV f)
        {
            da = new DAL.DA_ListSV();
            frm = f;
        }

        public void loadBang()
        {
            frm.dataGridView1.DataSource = da.loadBang();
        }
    }
}
