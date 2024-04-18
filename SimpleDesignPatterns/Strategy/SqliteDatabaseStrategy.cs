using System.Data.SQLite;

namespace SimpleDesignPatterns.Strategy;

public class SqliteDatabaseStrategy: IDatabaseStrategy
{
    private SQLiteConnection _connection;

    public SqliteDatabaseStrategy()
    {
        Connect();
    }

    public void Connect()
    {
        _connection = new SQLiteConnection("Data Source=MyDatabase.db;Version=3;");
        _connection.Open();
    }

    public void Query(string query)
    {
        SQLiteCommand command = new SQLiteCommand(query, _connection);
        var c = command.ExecuteNonQuery();
        Console.WriteLine($"Executing SQLite query: {query}, inserted: {c}");
    }

    public void Disconnect()
    {
        _connection.Close();
        Console.WriteLine("Disconnecting from SQLite database");
    }
}