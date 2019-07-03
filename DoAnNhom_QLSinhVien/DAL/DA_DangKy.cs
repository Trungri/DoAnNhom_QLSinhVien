using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoAnNhom_QLSinhVien.DAL
{
    class DA_DangKy
    {
        LOPDUNGCHUNG lopChung = new LOPDUNGCHUNG();

        public int DangKy(string TaiKhoan, string MatKhau)
        {
            string sql = "insert into Login values ('" + TaiKhoan + "','" + MatKhau + "')";

            return lopChung.executeNonQuery(sql);
        }
    }
}
