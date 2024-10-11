using App_HCG.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_HCG
{
    internal class Connection
    {
        private string constr = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=DB_HCG;Integrated Security=True;";
        private static Connection instance;

        public static Connection Instance
        {
            get { if (instance == null) instance = new Connection(); return Connection.instance; }
            private set { Connection.instance = value; }
        }

        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            for (int i = 0; i < parameters.Length; i++)
                            {
                                command.Parameters.Add(new SqlParameter($"@param{i}", parameters[i]));
                            }
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(data);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi ở đây (ví dụ: ghi log)
                    throw new Exception("Error executing query: " + ex.Message, ex);
                }
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            for (int i = 0; i < parameters.Length; i++)
                            {
                                command.Parameters.Add(new SqlParameter($"@param{i}", parameters[i]));
                            }
                        }
                        data = command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi ở đây (ví dụ: ghi log)
                    throw new Exception("Error executing non-query: " + ex.Message, ex);
                }
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = null;
            using (SqlConnection conn = new SqlConnection(constr))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            for (int i = 0; i < parameters.Length; i++)
                            {
                                command.Parameters.Add(new SqlParameter($"@param{i}", parameters[i]));
                            }
                        }
                        data = command.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi ở đây (ví dụ: ghi log)
                    throw new Exception("Error executing scalar query: " + ex.Message, ex);
                }
            }
            return data;
        }
    }
}
