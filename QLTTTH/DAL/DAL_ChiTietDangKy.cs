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

    public class DAL_ChiTietDangKy:DBConnect
    {
        public bool themChiTietDangKy(DTO_ChiTietDangKy ctdk)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.ChiTiet_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "INSERT");
            cmd.Parameters.AddWithValue("@Ngay_Dang_Ky", ctdk.Ngay_Dang_Ky);
            cmd.Parameters.AddWithValue("@Ma_HV", ctdk.Ma_HV);
            cmd.Parameters.AddWithValue("@Ma_LH", ctdk.Ma_LH);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool xoaChiTietDangKy(DTO_ChiTietDangKy ctdk)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.ChiTiet_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "DELETE");
            cmd.Parameters.AddWithValue("@Ngay_Dang_Ky", ctdk.Ngay_Dang_Ky);
            cmd.Parameters.AddWithValue("@Ma_HV", ctdk.Ma_HV);
            cmd.Parameters.AddWithValue("@Ma_LH", ctdk.Ma_LH);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
        }

        public bool suaChiTietDangKy(DTO_ChiTietDangKy ctdk)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("dbo.ChiTiet_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StatementType", "UPDATE");
            cmd.Parameters.AddWithValue("@Ngay_Dang_Ky", ctdk.Ngay_Dang_Ky);
            cmd.Parameters.AddWithValue("@Ma_HV", ctdk.Ma_HV);
            cmd.Parameters.AddWithValue("@Ma_LH", ctdk.Ma_LH);

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
