using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAL
{
    class DAL_HoaDon : DBConnect
    {

        public DataTable getHoaDon()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hoa_don", conn);
            DataTable dtHoaDon = new DataTable();
            da.Fill(dtHoaDon);
            return dtHoaDon;
        }

        public void bindGridView(DataGridView dataGridView)
        {
            conn.Open();
            string query = "SELECT * FROM Hoa_don";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }

        public bool themHoaDon(DTO_HoaDon hd)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.HoaDon_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_hd", null);
            cmd.Parameters.AddWithValue("@Ngay_lap", hd.Ma_hd);
            cmd.Parameters.AddWithValue("@Tong_tien", hd.Ngay_lap);
            cmd.Parameters.AddWithValue("@Tong_tien", hd.Tong_tien);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

    }
}
