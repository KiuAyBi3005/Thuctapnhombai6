﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySieuThi.DAO
{
   public class DataProvider
    {
       
            private static DataProvider instance;
            public static DataProvider Instance
            {
                get
                {
                    if (instance == null)
                        instance = new DataProvider();
                    return instance;
                }

                private set
                {
                    instance = value;
                }
            }
            private string connectionString = "Data Source=HUY-PC\\SQLEXPRESS;Initial Catalog=QuanLyBanHangSieuThi;Integrated Security=True";



            public DataTable ExecuteQuery(string query, object[] paramater = null)
            {
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (paramater != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, paramater[i]);
                                i++;
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();

                }
                return data;
            }
            public int ExecuteNonQuery(string query, object[] paramater = null)
            {
                int data = 0;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (paramater != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, paramater[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();
                    connection.Close();

                }
                return data;
            }
            public object ExecuteScalar(string query, object[] paramater = null)
            {
                object data = 0;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (paramater != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, paramater[i]);
                                i++;
                            }
                        }
                    }
                    data = command.ExecuteScalar();
                    connection.Close();

                }
                return data;

            }
        }
     
}
