﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;

namespace DataAccessTier
{
    public class LoaiKhachHangDAO: DBConnection
    {
        public LoaiKhachHangDAO()
        {
        }

        public DataTable LayThongTinLoaiKhachHang()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand command = new SqlCommand("LietKeThongTinLoaiKhachHang", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                DataTable result = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter(command);
                adap.Fill(result);
                connection.Close();
                return result;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }
		
		public LoaiKhachHangDTO getLoaiKhachByID(string pLoaiKhach)
        {
            LoaiKhachHangDTO loaiKhach = new LoaiKhachHangDTO();
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetLoaiKhachById";
                cmd.Parameters.Add("@ID",SqlDbType.VarChar,10).Value=pLoaiKhach;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    
                    loaiKhach.ID_LoaiKhachHang = reader["MaLoaiKhachHang"].ToString();
                    loaiKhach.TenLoaiKhachHang = reader["TenLoaiKhachHang"].ToString();
                }
                reader.Close();
            }
            catch (Exception)
            {
                connection.Close();
            }
            connection.Close();
            return loaiKhach;
        }
        public DataTable getDanhMucLoaiKhach()
        {
            DataTable dt = new DataTable();
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetDanhMucLoaiKhachHang";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                connection.Close();
            }catch(Exception)
            {
                connection.Close();
            }
            return dt;
        }
        public SqlCommand themLoaiKhachCmd(string pID, string pLoaiKhach)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("ThemLoaiKhachHang", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.VarChar, 10).Value = pID;
                cmd.Parameters.Add("@TenLoaiKhach", SqlDbType.NVarChar, 50).Value = pLoaiKhach;
                connection.Close();
                return cmd;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }
        //them loai khach
        public SqlCommand xoaLoaiKhachCmd(string pID)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
                SqlCommand cmd = new SqlCommand("XoaLoaiKhachHang", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLoaiKhach", SqlDbType.VarChar, 10).Value = pID;
                connection.Close();
                return cmd;
            }
            catch (Exception)
            {
                connection.Close();
            }
            return null;
        }
        //xoa loai khach
        public SqlCommand capNhapLoaiKhachCmd(string pID, string pLoaiKhach)
        {
            {
                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    SqlCommand cmd = new SqlCommand("CapNhapLoaiKhachHang", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaLoaiKhach", SqlDbType.VarChar, 10).Value = pID;
                    cmd.Parameters.Add("@LoaiKhach", SqlDbType.NVarChar, 50).Value = pLoaiKhach;
                    connection.Close();
                    return cmd;
                }
                catch (Exception)
                {
                    connection.Close();
                }
                return null;
            }
        }
    }
}
