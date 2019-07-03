using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
    class BL_SinhVien
    {
        GUI.frm_AddSV frm;
        DAL.DA_SinhVien da;
        public BL_SinhVien(GUI.frm_AddSV f)
        {
            da = new DAL.DA_SinhVien();
            frm = f;
        }

        public int Them()
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
            return da.Them(frm.txt_ID.Text, frm.txt_HoTen.Text, frm.dateTimePicker1.Text, gioiTinh, frm.txt_SoDT.Text, frm.txt_DiaChi.Text, frm.cb_MaLop.SelectedValue.ToString());
        }

        public void loadCombo()
        {
            frm.cb_MaLop.DataSource = da.loadCombo();
            frm.cb_MaLop.DisplayMember = "MaLop";
            frm.cb_MaLop.ValueMember = "TenLop";
        }

    }
}
