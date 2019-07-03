using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAnNhom_QLSinhVien.DAL
{
    class LOPDUNGCHUNG
    {
        String chuoiKetNoi = @"Data Source=DESKTOP-4GUJJOU;Initial Catalog=DoAnNhom_QuanLySinhVien;Integrated Security=True";
        SqlConnection connec;
        public LOPDUNGCHUNG()
        {
            connec = new SqlConnection(chuoiKetNoi);
        }

        public DataTable load(String sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, connec);
            adap.Fill(dt);
            return dt;
        }

        public int executeNonQuery(String sql)
        {
            SqlCommand comm = new SqlCommand(sql, connec);
            connec.Open();
            int ketQua = comm.ExecuteNonQuery();
            connec.Close();
            return ketQua;
        }

        public int executeScalar(String sql)
        {
            SqlCommand comm = new SqlCommand(sql, connec);
            connec.Open();
            int ketQua = (int)comm.ExecuteScalar();
            connec.Close();
            return ketQua;
        }
    }
}
