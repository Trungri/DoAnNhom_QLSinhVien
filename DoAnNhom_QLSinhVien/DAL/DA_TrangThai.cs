using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.DAL
{
    class DA_TrangThai
    {
        LOPDUNGCHUNG lopChung = new LOPDUNGCHUNG();

        public int demNam()
        {
            string sql_Dem = "Select Count (*) from SinhVien where GioiTinh = '"+"Nam"+"' ";
            return lopChung.executeScalar(sql_Dem);
        }

        public int demNu()
        {
            string sql_Dem = "Select Count (*) from SinhVien where GioiTinh = '" + "Nu" + "' ";
            return lopChung.executeScalar(sql_Dem);
        }
    }
}
