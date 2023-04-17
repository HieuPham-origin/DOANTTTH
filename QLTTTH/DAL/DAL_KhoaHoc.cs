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
    public class DAL_KhoaHoc : DBConnect
    {
        public DataTable getKhoaHoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Khoa_hoc", conn);
            DataTable dtKhoaHoc = new DataTable();
            da.Fill(dtKhoaHoc);
            return dtKhoaHoc;
        }

        public bool themKhoaHoc(DTO_KhoaHoc kh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Khoa_hoc VALUES (@Ten_KH, @Hoc_phi)", conn);
            cmd.Parameters.AddWithValue("@Ten_KH", kh.Ten_KH);
            cmd.Parameters.AddWithValue("@Hoc_phi", kh.Hoc_phi);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool suaKhoaHoc(DTO_KhoaHoc kh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Khoa_hoc SET Ten_KH = @Ten_KH, Hoc_phi = @Hoc_phi WHERE Ma_KH = @Ma_KH", conn);
            cmd.Parameters.AddWithValue("@Ten_KH", kh.Ten_KH);
            cmd.Parameters.AddWithValue("@Hoc_phi", kh.Hoc_phi);
            cmd.Parameters.AddWithValue("@Ma_KH", kh.Ma_KH);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool xoaKhoaHoc(DTO_KhoaHoc kh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Khoa_hoc WHERE Ma_KH = @Ma_KH", conn);
            cmd.Parameters.AddWithValue("@Ma_KH", kh.Ma_KH);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public void bindGridView(DataGridView dataGridView)
        {
            conn.Open();
            string query = "SELECT * from Khoa_hoc";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }

        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            conn.Open();
            string query = "SELECT * from Khoa_hoc where Ma_KH LIKE '%' + @name + '%' or Ten_KH LIKE '%' + @name + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }
    }
}
