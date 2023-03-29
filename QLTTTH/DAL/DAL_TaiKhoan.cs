﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_TaiKhoan : DBConnect
    {
        public DataTable getTaiKhoan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tai_Khoan", conn);
            DataTable dtThanhvien = new DataTable();
            da.Fill(dtThanhvien);
            return dtThanhvien;
        }


        public bool checkLogin(string username, string pass, int type) 
        {

            conn.Open();
            string query = "SELECT COUNT(*) FROM Tai_Khoan WHERE TaiKhoan=@username AND pass=@pass AND loai=@loai";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@loai", type);
            int count = (int)cmd.ExecuteScalar();
            conn.Close();
            if (count > 0)
            {
                return true;
            }

            return false;
            

        }
    }
}
