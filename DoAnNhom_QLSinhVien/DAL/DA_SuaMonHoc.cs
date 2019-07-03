using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAnNhom_QLSinhVien.DAL
{
    class DA_SuaMonHoc
    {
        LOPDUNGCHUNG lopChung = new LOPDUNGCHUNG();
        public DataTable loadCombo()
        {
            string sql = "select * from MonHoc";
            return lopChung.load(sql);
        }

        public int Sua( string TenMon, int soTC, string MoTa)
        {
            string sql_Sua = "update MonHoc set  SoTC = '" + soTC + "', MoTa = '" + MoTa + "'  where TenMon = '" + TenMon + "'";
            return lopChung.executeNonQuery(sql_Sua);
        }

    }
}
