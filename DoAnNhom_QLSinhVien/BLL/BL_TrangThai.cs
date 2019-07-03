using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
    class BL_TrangThai
    {
        GUI.frm_TrangThai frm;
        DAL.DA_TrangThai da;
        public BL_TrangThai(GUI.frm_TrangThai f)
        {
            da = new DAL.DA_TrangThai();
            frm = f;
        }

        public int demNam()
        {
            return da.demNam();
        }

        public int demNu()
        {
            return da.demNu();
        }
    }
}
