using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BlogData
{
    public class DataConnection
    {
        private string _connectionString = @"server=morgan--dk\morgan_l; initial catalog = BlogDb; integrated security = true";
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _commandBuilder;
        private string _selectQuery;
        private SqlCommand _sqlCommand;

        public string SelectQuery {
            get
            {
                return _selectQuery;
            }

            set
            {
                _selectQuery = value;
                _adapter.SelectCommand = new SqlCommand(value, new SqlConnection(_connectionString));
                _commandBuilder = new SqlCommandBuilder(_adapter);
            }
        }

        public SqlDataAdapter Adapter
        {
            get
            {
                return _adapter;
            }

            private set { }
        }

        public SqlCommand Command
        {
            get
            {
                return _sqlCommand;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        
        public DataConnection()
        {
            _adapter = new SqlDataAdapter();
            _sqlCommand = new SqlCommand(_selectQuery, new SqlConnection(_connectionString));
        }

        public DataConnection(string selectcommand)
        {
            _adapter = new SqlDataAdapter(selectcommand, new SqlConnection(_connectionString));
            _commandBuilder = new SqlCommandBuilder(_adapter);
            _sqlCommand = new SqlCommand(selectcommand, new SqlConnection(_connectionString));
        }

        public DataConnection(string selectcommand, string connectstring)
        {
            this._connectionString = connectstring;
            _adapter = new SqlDataAdapter(selectcommand, new SqlConnection(_connectionString));
            _commandBuilder = new SqlCommandBuilder(_adapter);
            _sqlCommand = new SqlCommand(selectcommand, new SqlConnection(_connectionString));
        }
    }
}
