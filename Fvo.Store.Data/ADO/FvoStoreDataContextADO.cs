using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fvo.Store.Data.ADO
{
    public class FvoStoreDataContextADO : IDisposable
    {
        private readonly SqlConnection _conn;

        public FvoStoreDataContextADO()
        {
            //var connString = ConfigurationManager.ConnectionStrings["FVOStoreConn"].ConnectionString;
            var connString = "Server=(localdb)\\mssqllocaldb;Database=FvoStore";
            _conn = new SqlConnection(connString);
            _conn.Open();
        }

        public void ExecuteCommand(string sql)
        {
            var command = new SqlCommand()
            {
                CommandText = sql,
                CommandType = System.Data.CommandType.Text,
                Connection = _conn
            };

            command.ExecuteNonQuery();

        }

        public SqlDataReader ExecuteCommandWithData(string query)
        {
            var command = new SqlCommand(query, _conn);
            return command.ExecuteReader();


        }
        public void Dispose()
        {
            if (_conn.State == System.Data.ConnectionState.Open)
            {
                _conn.Close();
            }
        }
    }
}
