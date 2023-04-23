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

        public void bindGridViewbySearch(DataGridView dataGridView, string name)
        {
            conn.Open();
            string query = "SELECT * from Hoc_vien where Ma_HV LIKE '%' + @name + '%' or Ten_HV LIKE '%' + @name + '%' or sdt LIKE '%' + @name + '%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);
            dataGridView.DataSource = dt;
            conn.Close();
        }


        public void bindLHComboBoxByKH(ComboBox cbx, string ten_kh)
        {
            conn.Open();
            // Get the Ma_KH based on the name of the Khoa Hoc
            SqlCommand command1 = new SqlCommand("SELECT Ma_KH FROM Khoa_hoc WHERE Ten_KH=@ten_kh", conn);
            command1.Parameters.AddWithValue("@ten_kh", ten_kh);
            int ma_kh = (int)command1.ExecuteScalar();

            // Query the Lop_hoc table based on the retrieved Ma_KH
            SqlCommand command2 = new SqlCommand("SELECT Ma_LH, Ten_LH FROM Lop_hoc WHERE Ma_KH=@ma_kh", conn);
            command2.Parameters.AddWithValue("@ma_kh", ma_kh);
            SqlDataReader reader = command2.ExecuteReader();
            Dictionary<int, string> items = new Dictionary<int, string>();
            while (reader.Read())
            {
                items.Add(reader.GetInt32(0), reader.GetString(1));
            }
            cbx.DataSource = new BindingSource(items, null);
            cbx.DisplayMember = "Value";
            cbx.ValueMember = "Key";
            conn.Close();
        }

    }
}
