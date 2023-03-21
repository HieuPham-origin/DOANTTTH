using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static DTO.DTO_KhoaHoc;
using System.Data;
namespace DAL
{
    public class DAL_KhoaHoc : DBConnect
    {
        public DataTable getKhoaHoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Khoa_hoc", conn);
            DataTable dtKhoaHoc = new DataTable();
            da.Fill(dtKhoaHoc);
            return dtKhoaHoc;
        }
    }
}
