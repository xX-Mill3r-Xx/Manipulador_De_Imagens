using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace InserirAnexo.Conexao
{
    public class DataBaseConnection : IDisposable
    {
        #region Properties

        private readonly SqlConnection _connection;
        private bool _disposed = false;

        #endregion Properties

        #region Constructors

        public DataBaseConnection(string sqlConection)
        {
            _connection = new SqlConnection(sqlConection);
            _connection.Open();
        }

        #endregion Constructors

        #region Métodos

        public IEnumerable<T> Query<T>(string sql, object parameters = null)
        {
            using (var connection = new SqlConnection(_connection.ConnectionString))
            {
                connection.Open();
                return connection.Query<T>(sql, parameters);
            }
        }

        public int Execute(string sql, object parameters = null)
        {
            using (var connection = new SqlConnection(_connection.ConnectionString))
            {
                connection.Open();
                return connection.Execute(sql, parameters);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (_connection != null && _connection.State != System.Data.ConnectionState.Closed)
                    {
                        _connection.Close();
                        _connection.Dispose();
                    }
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DataBaseConnection()
        {
            Dispose(false);
        }

        #endregion Métodos
    }
}
