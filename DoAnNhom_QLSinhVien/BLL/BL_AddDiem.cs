using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
    class BL_AddDiem
    {
        GUI.frm_AddDiem frm;
        DAL.DA_AddDiem da;
        public BL_AddDiem(GUI.frm_AddDiem f)
        {
            da = new DAL.DA_AddDiem();
            frm = f;
        }
        public void loadCombo()
        {
            frm.cb_MonHoc.DataSource = da.loadCombo();
            frm.cb_MonHoc.DisplayMember = "TenMon";
            frm.cb_MonHoc.ValueMember = "MaMon";
        }

        public void loadCombo_SV()
        {
            frm.cb_IDSV.DataSource = da.loadCombo_SV();
            frm.cb_IDSV.DisplayMember = "ID";
            frm.cb_IDSV.ValueMember = "HoTen";
        }

        public void loadBang()
        {
            frm.dataGridView1.DataSource = da.loadBang();
        }

        public int Them()
        {
            return da.Them(frm.cb_IDSV.Text, frm.cb_MonHoc.SelectedValue.ToString(), Int32.Parse(frm.txt_Diem.Text), frm.txt_GhiChu.Text);
        }
    }
}
