using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class DAL_LopHoc : DBConnect
    {
        public DataTable getLopHoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Lop_hoc", conn);
            DataTable dtKhoaHoc = new DataTable();
            da.Fill(dtKhoaHoc);
            return dtKhoaHoc;
        }

        
        public void bindComboBox(ComboBox cbx)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Ten_KH FROM Khoa_Hoc", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbx.Items.Add(reader.GetString(0));
            }
            conn.Close();
        }
    }
}
