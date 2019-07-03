using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
    class BL_SV_updateDelete
    {
        GUI.frm_UpdateDelete frm;
        DAL.DA_SV_updateDelete da;
        public BL_SV_updateDelete(GUI.frm_UpdateDelete f)
        {
            da = new DAL.DA_SV_updateDelete();
            frm = f;
        }

        
        public int Sua()
        {
            string gioiTinh;
            if (frm.radio_Nam.Checked == true)
            {
                gioiTinh = frm.radio_Nam.Text;
            }
            else
            {
                gioiTinh = frm.radio_Nu.Text;
            }
            return da.Sua(frm.txt_ID.Text, frm.txt_HoTen.Text, frm.dateTimePicker1.Text, gioiTinh, frm.txt_SoDT.Text, frm.txt_DiaChi.Text);
        }

        public int Xoa()
        {
            return da.Xoa(frm.txt_ID.Text);

        }
    }
}
