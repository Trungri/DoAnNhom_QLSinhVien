using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAnNhom_QLSinhVien.DAL
{
    class DA_XoaMonHoc
    {
        LOPDUNGCHUNG lopChung = new LOPDUNGCHUNG();
        public DataTable loadCombo()
        {
            string sql = "select * from MonHoc";
            return lopChung.load(sql);
        }

        public int Xoa(string MaMon)
        {
            string sql_Xoa = "Delete from MonHoc where MaMon = '" + MaMon + "'";
            return lopChung.executeNonQuery(sql_Xoa);
        }
    }
}
