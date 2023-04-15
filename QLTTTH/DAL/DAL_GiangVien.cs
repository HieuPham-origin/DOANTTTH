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
    public class DAL_GiangVien : DBConnect
    {
        public DataTable getHocVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Hoc_vien", conn);
            DataTable dtHocVien = new DataTable();
            da.Fill(dtHocVien);
            return dtHocVien;
        }

        public bool themGiangVien(DTO_GiangVien gv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.GiangVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_GV", null);
            cmd.Parameters.AddWithValue("@Ten_GV", gv.Ten_GV);
            cmd.Parameters.AddWithValue("@Nam_sinh", gv.Nam_sinh);
            cmd.Parameters.AddWithValue("@sdt", gv.Sdt);
            cmd.Parameters.AddWithValue("@Que_quan", gv.Que_quan);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool suaGiangVien(DTO_GiangVien gv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.GiangVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ma_GV", gv.Ma_GV);
            cmd.Parameters.AddWithValue("@Ten_GV", gv.Ten_GV);
            cmd.Parameters.AddWithValue("@Nam_sinh", gv.Nam_sinh);
            cmd.Parameters.AddWithValue("@sdt", gv.Sdt);
            cmd.Parameters.AddWithValue("@Que_quan", gv.Sdt);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaGiangVien(DTO_GiangVien gv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.GiangVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ma_GV", gv.Ma_GV);
            cmd.Parameters.AddWithValue("@Ten_GV", gv.Ten_GV);
            cmd.Parameters.AddWithValue("@Nam_sinh", gv.Nam_sinh);
            cmd.Parameters.AddWithValue("@sdt", gv.Sdt);
            cmd.Parameters.AddWithValue("@Que_quan", gv.Sdt);

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
            string query = "SELECT * from Giang_vien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }

    }

}
