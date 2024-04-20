using SimpleDesignPatterns.Strategy.IDatabases;

namespace SimpleDesignPatterns.Strategy;

public abstract class NoSqlDatabase : INoSqlDatabase
{
    public virtual void Connect()
    {
        // Generic connection logic for NoSQL databases
        Console.WriteLine("Connecting to NoSQL database...");
    }

    public virtual void Disconnect()
    {
        // Generic disconnection logic for NoSQL databases
        Console.WriteLine("Disconnecting from NoSQL database...");
    }

    public abstract void Query(string query);
}