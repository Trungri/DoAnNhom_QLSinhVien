using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.BLL
{
    class BL_QLDiem
    {
        GUI.frm_QuanLiDiem frm;
        DAL.DA_QLDiem da;
        public BL_QLDiem(GUI.frm_QuanLiDiem f)
        {
            da = new DAL.DA_QLDiem();
            frm = f;
        }
        public void loadCombo()
        {
            frm.cb_IDSV.DataSource = da.loadCombo();
            frm.cb_IDSV.DisplayMember = "ID";
            frm.cb_IDSV.ValueMember = "HoTen";
        }

        public void loadBang()
        {
            frm.dataGridView1.DataSource = da.loadBang();
        }
        
        public void loadData()
        {
            frm.dataGridView1.DataSource = da.loadData(frm.cb_IDSV.Text);
            
        }

        public void loadBang_SVDat()
        {
            frm.dataGridView1.DataSource = da.loadBang_SVDat();
        }

        public void loadBang_SVKhongDat()
        {
            frm.dataGridView1.DataSource = da.loadBang_SVKhongDat();
        }
    }
}
