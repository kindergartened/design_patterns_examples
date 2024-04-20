using SimpleDesignPatterns.Strategy.IDatabases;

namespace SimpleDesignPatterns.Strategy;

public class PostgresDatabase : SqlDatabase, ISqlDatabase
{
    public override void Connect()
    {
        Console.WriteLine("Connecting to PostgreSQL database");
    }

    public override void Query(string query)
    {
        // Implement PostgreSQL query execution here
        Console.WriteLine("Executing PostgreSQL query: " + query);
    }

    public PostgresDatabase(string connectionString) : base(connectionString) { }
}