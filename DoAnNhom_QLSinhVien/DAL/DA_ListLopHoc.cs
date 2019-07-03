using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAnNhom_QLSinhVien.DAL
{
    class DA_ListLopHoc
    {

        LOPDUNGCHUNG lopChung = new LOPDUNGCHUNG();
        public DataTable loadBang()
        {
            String sql = "select * from LopHoc";
            return lopChung.load(sql);
        }
    }
}
