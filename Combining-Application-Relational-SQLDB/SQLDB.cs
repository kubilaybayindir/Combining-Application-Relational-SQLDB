using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Combining_Application_Relational_SQLDB
{
    public class SQLDB
    {
        SqlConnection Connection;
        SqlDataAdapter Adapter = new SqlDataAdapter();
        SqlCommand Command = new SqlCommand();
        public bool ConnectionState { get; set; }
        
        public void Sql(string connectionstring)
        {
            Connection = new SqlConnection(connectionstring);
            ConnectionState = false;
        }
        public bool ConnectionOpen()
        {
            try
            {
                Connection.Open();
                ConnectionState = true;
                return true;
            }
            catch (Exception ex)
            {
                ConnectionState = false;
                return false;
            }
        }
        public bool ConnectionClose()
        {
            try
            {
                Connection.Close();
                ConnectionState = false;
                return true;
            }
            catch (Exception ex)
            {
                ConnectionState = true;
                return false;
            }
        }
        public DataTable GetTable(string tableName, string columnNames, string criteria)
        {
            DataTable table = new DataTable();
            string commandtext = "SELECT " + columnNames + " FROM " + tableName + " " + criteria;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            Adapter.SelectCommand = Command;
            Adapter.Fill(table);
            return table;
        }
        public DataTable GetTableFromProcedure(string procedureName)
        {
            DataTable table = new DataTable();
            string commandtext = "Execute " + procedureName;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            Adapter.SelectCommand = Command;
            Adapter.Fill(table);
            return table;
        }
        public long GetTableBigint(string tableName, string columnNames, string criteria)
        {
            DataTable table = new DataTable();
            long value = -1;
            string commandtext = "SELECT " + columnNames + " FROM " + tableName + " " + criteria;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            Adapter.SelectCommand = Command;
            Adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                value = (long)(table.Rows[0][0]);
            }
            return value;
        }
        public string GetTableString(string tableName, string columnNames, string criteria)
        {
            DataTable table = new DataTable();
            string value = "";
            string commandtext = "SELECT " + columnNames + " FROM " + tableName + " " + criteria;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            Adapter.SelectCommand = Command;
            Adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                value = (string)(table.Rows[0][0]);
            }
            return value;
        }
        public bool Delete(string tableName, string criteria)
        {
            string commandtext = "DELETE FROM " + tableName + " " + criteria;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool Update(string tableName, string values, string criteria)
        {
            string commandtext = "UPDATE " + tableName + " SET " + values + " " + criteria;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool Insert(string tableName, string columnNames, string values, string criteria)
        {
            string commandtext = "INSERT INTO " + tableName + "(" + columnNames + ") values(" + values + ") " + criteria;
            Command.Connection = Connection;
            Command.CommandText = commandtext;
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
