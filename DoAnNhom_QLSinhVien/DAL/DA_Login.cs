using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnNhom_QLSinhVien.DAL
{
    class DA_Login
    {
        LOPDUNGCHUNG lopChung = new LOPDUNGCHUNG();

        public int Login(string TaiKhoan, string MatKhau)
        {
            string sql = "Select Count (*) from Login where TaiKhoan = '"
                + TaiKhoan + "'and MatKhau = '"
                + MatKhau + "'";
            
            return lopChung.executeScalar(sql);
        }
    }
}
