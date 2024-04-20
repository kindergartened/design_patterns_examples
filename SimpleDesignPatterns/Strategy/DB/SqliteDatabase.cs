using System.Data.SQLite;
using SimpleDesignPatterns.Strategy.IDatabases;

namespace SimpleDesignPatterns.Strategy.DB;

public class SqliteDatabase : SqlDatabase, ISqlDatabase
{
    private SQLiteConnection _connection;

    public SqliteDatabase(string connection) : base(connection)
    {
        _connection = new SQLiteConnection(connection);
    }

    public override void Query(string query)
    {
        _connection.Open();
        var command = new SQLiteCommand(query, _connection);
        Console.WriteLine($"Making query: {query}");
        command.ExecuteNonQuery();
        _connection.Close();
    }
}