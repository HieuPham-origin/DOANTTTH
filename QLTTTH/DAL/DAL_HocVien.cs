using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static DTO.DTO_HocVien;
using System.Data;
using DTO;
using System.Windows.Forms;

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

        public bool themHocVien(DTO_HocVien hv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.HocVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_HV", null);
            cmd.Parameters.AddWithValue("@Ten_HV", hv.Ten_HV);
            cmd.Parameters.AddWithValue("@Nam_sinh", hv.Nam_sinh);
            cmd.Parameters.AddWithValue("@Dia_chi", hv.Dia_chi);
            cmd.Parameters.AddWithValue("@sdt", hv.Sdt);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool suaHocVien(DTO_HocVien hv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.HocVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ma_HV", hv.Ma_HV);
            cmd.Parameters.AddWithValue("@Ten_HV", hv.Ten_HV);
            cmd.Parameters.AddWithValue("@Nam_sinh", hv.Nam_sinh);
            cmd.Parameters.AddWithValue("@Dia_chi", hv.Dia_chi);
            cmd.Parameters.AddWithValue("@sdt", hv.Sdt);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaHocVien(DTO_HocVien hv)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.HocVien_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ma_HV", hv.Ma_HV);
            cmd.Parameters.AddWithValue("@Ten_HV", hv.Ten_HV);
            cmd.Parameters.AddWithValue("@Nam_sinh", hv.Nam_sinh);
            cmd.Parameters.AddWithValue("@Dia_chi", hv.Dia_chi);
            cmd.Parameters.AddWithValue("@sdt", hv.Sdt);

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
            string query = "SELECT * from Hoc_vien";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }
    }
}
