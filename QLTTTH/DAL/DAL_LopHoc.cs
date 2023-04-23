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


        public void bindGridView(DataGridView dataGridView)
        {
            conn.Open();
            string query = "SELECT * from Lop_Hoc";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter dv = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dv.Fill(dt);

            dataGridView.DataSource = dt;
            conn.Close();
        }

        public void bindKHComboBox(ComboBox cbx)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Ma_KH, Ten_KH FROM Khoa_Hoc", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbx.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
            }
            cbx.DisplayMember = "Value";
            cbx.ValueMember = "Key";
            conn.Close();
        }


        public void bindCHComboBox(ComboBox cbx)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Ma_ca FROM Ca_hoc", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbx.Items.Add(Convert.ToInt32(reader["Ma_ca"]));
            }
            conn.Close();
        }

        public void bindPHComboBox(ComboBox cbx)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Ma_PH, Ten_PH FROM Phong_hoc", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbx.Items.Add(new KeyValuePair<int, string>(reader.GetInt32(0), reader.GetString(1)));
            }
            cbx.ValueMember = "Key";
            cbx.DisplayMember = "Value";
            conn.Close();
        }

        public void bindGVComboBox(ComboBox cbx)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Ma_GV, Ten_GV FROM Giang_vien", conn);
            SqlDataReader reader = command.ExecuteReader();
            Dictionary<string, string> items = new Dictionary<string, string>();
            while (reader.Read())
            {
                string maGV = reader.GetString(0);
                string tenGV = reader.GetString(1);
                items.Add(maGV, tenGV);
            }
            cbx.DataSource = new BindingSource(items, null);
            cbx.DisplayMember = "Value";
            cbx.ValueMember = "Key";
            conn.Close();
        }




        public bool themLopHoc(DTO_LopHoc lh)
        {
            // kiem tra trung ma_ca va ma_ph
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Lop_hoc WHERE Ma_ph=@Ma_ph AND Ma_ca=@Ma_ca", conn);
            checkCmd.Parameters.AddWithValue("@Ma_ph", lh.Ma_PH);
            checkCmd.Parameters.AddWithValue("@Ma_ca", lh.Ma_ca);
            conn.Open();
            int count = (int)checkCmd.ExecuteScalar();
            conn.Close();

            // tra ve false neu da trung ma_ca va ma_ph
            if (count > 0)
                return false;

            // Them lop hoc
            SqlCommand cmd = new SqlCommand("dbo.LopHoc_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ma_LH", null);
            cmd.Parameters.AddWithValue("@Ten_LH", lh.Ten_LH);
            cmd.Parameters.AddWithValue("@Ma_KH", lh.Ma_KH);
            cmd.Parameters.AddWithValue("@Ma_PH", lh.Ma_PH);
            cmd.Parameters.AddWithValue("@Ma_ca", lh.Ma_ca);
            cmd.Parameters.AddWithValue("@Ma_GV", lh.Ma_GV);
            cmd.Parameters.AddWithValue("@Ngay_bat_dau", lh.Ngay_bat_dau);
            cmd.Parameters.AddWithValue("@Ngay_ket_thuc", lh.Ngay_ket_thuc);
            cmd.Parameters.AddWithValue("@Dang_mo", lh.Dang_Mo);
            cmd.Parameters.AddWithValue("@So_buoi", lh.So_buoi);
            cmd.Parameters.AddWithValue("@Soluong", lh.Soluong);

            conn.Open();
            int i = cmd.ExecuteNonQuery();
            conn.Close();

            if (i != 0)
                return true;

            return false;
        }



        public bool suaLopHoc(DTO_LopHoc lh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.LopHoc_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ma_LH", lh.Ma_LH);
            cmd.Parameters.AddWithValue("@Ten_LH", lh.Ten_LH);
            cmd.Parameters.AddWithValue("@Ma_KH", lh.Ma_KH);
            cmd.Parameters.AddWithValue("@Ma_PH", lh.Ma_PH);
            cmd.Parameters.AddWithValue("@Ma_ca", lh.Ma_ca);
            cmd.Parameters.AddWithValue("@Ma_GV", lh.Ma_GV);
            cmd.Parameters.AddWithValue("@Ngay_bat_dau", lh.Ngay_bat_dau);
            cmd.Parameters.AddWithValue("@Ngay_ket_thuc", lh.Ngay_ket_thuc);
            cmd.Parameters.AddWithValue("@Dang_mo", lh.Dang_Mo);
            cmd.Parameters.AddWithValue("@So_buoi", lh.So_buoi);
            cmd.Parameters.AddWithValue("@Soluong", lh.Soluong);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }


        public bool xoaLopHoc(DTO_LopHoc lh)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.LopHoc_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ma_LH", lh.Ma_LH);
            cmd.Parameters.AddWithValue("@Ten_LH", lh.Ten_LH);
            cmd.Parameters.AddWithValue("@Ma_KH", lh.Ma_KH);
            cmd.Parameters.AddWithValue("@Ma_PH", lh.Ma_PH);
            cmd.Parameters.AddWithValue("@Ma_ca", lh.Ma_ca);
            cmd.Parameters.AddWithValue("@Ma_GV", lh.Ma_GV);
            cmd.Parameters.AddWithValue("@Ngay_bat_dau", lh.Ngay_bat_dau);
            cmd.Parameters.AddWithValue("@Ngay_ket_thuc", lh.Ngay_ket_thuc);
            cmd.Parameters.AddWithValue("@Dang_mo", lh.Dang_Mo);
            cmd.Parameters.AddWithValue("@So_buoi", lh.So_buoi);
            cmd.Parameters.AddWithValue("@Soluong", lh.Soluong);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public int getMaLHFromTenLH(string tenLH)
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT Ma_LH FROM Lop_hoc WHERE Ten_LH = @TenLH", conn);
            command.Parameters.AddWithValue("@TenLH", tenLH);
            int maLH = (int)command.ExecuteScalar();
            conn.Close();
            return maLH;
        }


        public string getNameById(int id)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Ten_LH FROM Lop_hoc WHERE  Ma_LH = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            string name = "";
            if (reader.Read())
            {
                name = reader["Ten_LH"].ToString();
            }
            conn.Close();
            return name;
        }


    }
}
