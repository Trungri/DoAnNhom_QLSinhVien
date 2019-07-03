using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAnNhom_QLSinhVien.DAL
{
    class DA_AddDiem
    {
        LOPDUNGCHUNG lopChung = new LOPDUNGCHUNG();
        public DataTable loadCombo()
        {
            string sql = "select * from MonHoc";
            //string sql = "select TenMon from MonHoc where Diem_MonHoc.ID_MonHoc = MonHoc.MaMon";
            return lopChung.load(sql);
        }

        public DataTable loadCombo_SV()
        {
            string sql = "select * from SinhVien";
            //string sql = "select TenMon from MonHoc where Diem_MonHoc.ID_MonHoc = MonHoc.MaMon";
            return lopChung.load(sql);
        }

        public DataTable loadBang()
        {
            String sql = "select * from Diem_MH";
            return lopChung.load(sql);
        }

        public int Them(string IDSV, string ID_MonHoc, int Diem, string GhiChu)
        {
            string sql_Them = "insert into Diem_MH values ('" + IDSV + "' ,  '" + ID_MonHoc + "' ,  '" + Diem + "' , '" + GhiChu + "' )";
            //string sql_Sua = " Diem_MonHoc set  IDSV = '" + IDSV + "', Diem = '" + Diem + "' , GhiChu = '" + GhiChu + "'  where ID_MonHoc = '" + ID_MonHoc + "'";
            return lopChung.executeNonQuery(sql_Them);
        }
    }
}
