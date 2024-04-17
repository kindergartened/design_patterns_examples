using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SimpleDesignPatterns.Strategy
{
    public class SqliteDatabaseStrategy: IDatabaseStrategy
    {
        private SQLiteConnection _connection;

        public void Connect()
        {
            _connection = new SQLiteConnection("Data Source=MyDatabase.db;Version=3;");
            _connection.Open();
            Console.WriteLine("Connecting to SQLite database");
        }

        public void Query(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, _connection);
            command.ExecuteNonQuery();
            Console.WriteLine("Executing SQLite query: " + query);
        }

        public void Disconnect()
        {
            _connection.Close();
            Console.WriteLine("Disconnecting from SQLite database");
        }
    }
}
