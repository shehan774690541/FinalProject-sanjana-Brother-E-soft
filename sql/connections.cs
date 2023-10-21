using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject.sql;

namespace FinalProject.sql
{
    internal class connections
    {
        private MySqlConnection connection;

        private void Initialize()
        {
            ConnectionsVariable connectionsVariable = new ConnectionsVariable();
            string connectionString;
            connectionString = $"SERVER={connectionsVariable.Server};DATABASE={connectionsVariable.Database};UID={connectionsVariable.User};PASSWORD={connectionsVariable.Password};";

            connection = new MySqlConnection(connectionString); 
        }

        public bool CheckConnection()
        {
            try
            {
                if (connection != null)
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        return true;
                    }
                    else
                    {
                        connection.Open();
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (MySqlException)
            {
                return false;
            }
            finally
            {
                try
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
