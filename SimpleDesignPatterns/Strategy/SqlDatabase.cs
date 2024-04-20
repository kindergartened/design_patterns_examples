using SimpleDesignPatterns.Strategy.IDatabases;

namespace SimpleDesignPatterns.Strategy;

public abstract class SqlDatabase : ISqlDatabase
{
    private string _connectionString;

    protected SqlDatabase(string connectionString)
    {
        _connectionString = connectionString;
    }

    public virtual void Connect()
    {
        // generic connection logic for SQL databases
        Console.WriteLine("Connecting to SQL database...");
    }

    public virtual void Disconnect()
    {
        // generic disconnection logic for SQL databases
        Console.WriteLine("Disconnecting from SQL database...");
    }

    public abstract void Query(string query);
}