using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class DataAccessHelper
    {
        #region ConnectionString

        public static string ConnectionString
        {
            get
            {
                return "Server=localhost;User Id=root;Password=3725141531;Database=quanlynhasach";
            }
        }


        #endregion
        #region ExecuteQuery

        public static DataTable ExecuteQuery(string spName, List<MySqlParameter> parameters = null)
        {
            var dt = new DataTable();
            try
            {
                var connect = new MySqlConnection(ConnectionString);
                connect.Open();
                try
                {
                    MySqlCommand command = connect.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spName;

                    if(parameters != null)
                    {
                        foreach(var parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                    //var ds = new DataSet();
                    //ds.Reset();
                    //var adapter = new SQLiteDataAdapter(query, connect);
                    //adapter.Fill(ds);
                    //dt = ds.Tables[0];
                }

                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        #endregion
        #region ExecuteNonQuery

        public static int ExecuteNonQuery(string spName, List<MySqlParameter> parameters = null)
        {
            int n;
            try
            {
                var connect = new MySqlConnection(ConnectionString);
                connect.Open();
                try
                {
                    MySqlCommand command = connect.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spName;

                    if(parameters != null)
                    {
                        foreach(MySqlParameter parameter in parameters)
                        {
                            command.Parameters.Add(parameter);
                        }
                    }

                    //var command = connect.CreateCommand();
                    //command.CommandText = query;
                    n = command.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return n;
        }

        #endregion
    }
}
