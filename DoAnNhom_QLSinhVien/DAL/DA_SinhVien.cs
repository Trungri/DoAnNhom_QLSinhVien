using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAnNhom_QLSinhVien.DAL
{
    class DA_SinhVien
    {
        LOPDUNGCHUNG lopChung = new LOPDUNGCHUNG();

        public int Them(string ID, string HoTen, string NgaySinh, string GioiTinh, string SDT, string DiaChi, string MaLop)
        {
            string sql_Them = "insert into SinhVien values ('" + ID + "' ,  '" + HoTen + "' ,  '" + NgaySinh + "' , '" + GioiTinh + "' , '" + SDT + "' , '" + DiaChi + "' , '" + MaLop + "' )";
            return lopChung.executeNonQuery(sql_Them);
        }

        public DataTable loadCombo()
        {
            string sql = "select * from LopHoc";

            return lopChung.load(sql);
        }

    }
}
