using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
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
        public int ExecuteNonQueryWithOutputMaLopHoc(string query, object[] parameters, out object outputValue, string outputParamName = "@MaLopHoc")
        {
            int rowsAffected = 0;
            outputValue = null;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                // Thêm các tham số đầu vào
                if (parameters != null)
                {
                    string[] values = query.Split(' ');
                    int i = 0;
                    foreach (string item in values)
                    {
                        if (item.Contains('@') && item != outputParamName)  // Bỏ qua tham số đầu ra
                        {
                            cmd.Parameters.AddWithValue(item, parameters[i]);
                            i++;
                        }
                    }
                }

                // Thêm tham số đầu ra
                SqlParameter outputParam = new SqlParameter(outputParamName, SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outputParam);

                rowsAffected = cmd.ExecuteNonQuery();
                outputValue = outputParam.Value;
                connection.Close();
            }

            return rowsAffected;
        }
        public int ExcuteNonQuerySignUp(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    if (parameter != null)
                    {
                        string[] parameterNames = query.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                        int i = 0;
                        foreach (string item in parameterNames)
                        {
                            if (item.StartsWith("@"))
                            {
                                
                                var param = cmd.Parameters.AddWithValue(item, parameter[i]);
                                // Đặt hướng của tham số nếu là OUTPUT
                                if (parameter[i] == null && item.Equals("@UserId"))
                                {
                                    param.Direction = ParameterDirection.Output;
                                }
                                i++;
                            }
                        }
                    }

                    data = cmd.ExecuteNonQuery();
                }
            }
            return data;
        }

    }
}
