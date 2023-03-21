using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static DTO.DTO_HocVien;
using System.Data;

namespace DAL
{
    public class DAL_HocVien : DBConnect
    {
        public DataTable getHocVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hoc_vien", conn);
            DataTable dtHocVien = new DataTable();
            da.Fill(dtHocVien);
            return dtHocVien;
        }

        public static void Main()
        {
            DAL_HocVien a = new DAL_HocVien();
            foreach (DataRow dataRow in a.getHocVien().Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
