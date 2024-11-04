﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingClassManagementSystem
{
    public class DataProvider
    {

        private string connectionStr = "Data Source=LOCALHOST\\SQLEXPRESS01;Initial Catalog=QLLHNA;Integrated Security=True";
                        // Đổi tên data source 
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) return instance = new DataProvider(); return DataProvider.instance; }
            private set { instance = value; }
        }
        private DataProvider() { }

        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] values = query.Split(' ');
                    int i = 0;
                    foreach (string item in values)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;

                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                try
                {
                    adapter.Fill(data);
                }
                catch (Exception e)
                {

                }
                connection.Close();
            }
            return data;
        }

        public object ExcuteNonQuery(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] values = query.Split(' ');
                    int i = 0;
                    foreach (string item in values)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;

                        }
                    }
                }

                data = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] values = query.Split(' ');
                    int i = 0;
                    foreach (string item in values)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;

                        }
                    }
                }
                data = cmd.ExecuteScalar();
                return data;
            }

        }
    }
}