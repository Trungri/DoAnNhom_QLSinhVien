using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.DAL
{
    class DA_SV_updateDelete
    {
        LOPDUNGCHUNG lopChung = new LOPDUNGCHUNG();

        public int Sua(string ID, string HoTen, string NgaySinh, string GioiTinh, string SDT, string DiaChi)
        {
            string sql_Sua = "update SinhVien set HoTen = '" + HoTen + "',NgaySinh = '" + NgaySinh + "' , GioiTinh= '" + GioiTinh + "' , SDT= '" + SDT + "' , DiaChi= '" + DiaChi + "' where ID = '" + ID + "'";
            return lopChung.executeNonQuery(sql_Sua);
        }

        public int Xoa(string ID)
        {
            string sql_Xoa = "Delete from SinhVien where ID = '" + ID + "'";
            return lopChung.executeNonQuery(sql_Xoa);
        }
    }
}
