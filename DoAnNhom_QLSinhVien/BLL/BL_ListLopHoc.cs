using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
    class BL_ListLopHoc
    {
        GUI.frm_DanhSachLH frm;
        DAL.DA_ListLopHoc da;
        public BL_ListLopHoc(GUI.frm_DanhSachLH f)
        {
            da = new DAL.DA_ListLopHoc();
            frm = f;
        }

        public void loadBang()
        {
            frm.dataGridView1.DataSource = da.loadBang();
        }
    }
}
