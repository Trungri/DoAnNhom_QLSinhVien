using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.DAL
{
    class DA_MonHoc
    {
        LOPDUNGCHUNG lopChung = new LOPDUNGCHUNG();

        public int Them(string MaMon, string TenMon, int SoTC, string MoTa)
        {
            string sql_Them = "insert into MonHoc values ('" + MaMon + "' ,  '" + TenMon + "' ,  '" + SoTC + "' , '" + MoTa + "' )";
            return lopChung.executeNonQuery(sql_Them);
        }
    }
}
