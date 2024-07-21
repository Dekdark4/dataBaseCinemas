using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePoster
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance = null;
        private SqlConnection connection = null;

        private DatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CinemasDB"].ConnectionString;
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }

        public SqlConnection Connection
        {
            get { return connection; }
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
