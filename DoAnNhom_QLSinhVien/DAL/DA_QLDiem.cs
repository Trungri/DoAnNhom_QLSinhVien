using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAnNhom_QLSinhVien.DAL
{
    class DA_QLDiem
    {
        LOPDUNGCHUNG lopChung = new LOPDUNGCHUNG();
        public DataTable loadCombo()
        {
            string sql = "select * from SinhVien";
            return lopChung.load(sql);
        }

        public DataTable loadBang()
        {
            String sql = "select * from Diem_MH";
            return lopChung.load(sql);
        }
        public DataTable loadBang_SVDat()
        {
            String sql = "select * from Diem_MH where Diem >= '"+5+"'";
            return lopChung.load(sql);
        }

        public DataTable loadBang_SVKhongDat()
        {
            String sql = "select * from Diem_MH where Diem < '" + 5 + "'";
            return lopChung.load(sql);
        }

        public DataTable loadData(string MaSV)
        {
            String sql = "select * from Diem_MH where ID_SV = '"+MaSV+"' ";
            return lopChung.load(sql);
        }
    }
}
