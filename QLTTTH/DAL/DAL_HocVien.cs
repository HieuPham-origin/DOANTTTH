using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static DTO.DTO_HocVien;
using System.Data;
using DTO;
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

        public bool addHocVien(DTO_HocVien hv)
        {
            try {
                conn.Open();


            }
            catch (Exception e)
            {
                
            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }

            return false;
        }


    }
}
