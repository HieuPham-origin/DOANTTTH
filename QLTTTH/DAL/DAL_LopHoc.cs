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


        public bool themLopHoc(DTO_LopHoc lh)
        {
            conn.Open();
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

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
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
    }
}
