using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAnNhom_QLSinhVien.DAL
{
    class DA_ListMonHoc
    {
        LOPDUNGCHUNG lopChung = new LOPDUNGCHUNG();
        public DataTable loadBang()
        {
            String sql = "select * from MonHoc";
            return lopChung.load(sql);
        }
    }
}
