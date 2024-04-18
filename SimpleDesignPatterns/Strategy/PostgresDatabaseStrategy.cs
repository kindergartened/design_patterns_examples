namespace SimpleDesignPatterns.Strategy;

public class PostgresDatabaseStrategy
{
    public void Connect()
    {
        Console.WriteLine("Connecting to PostgreSQL database");
    }

    public void Query(string query)
    {
        // Implement PostgreSQL query execution here
        Console.WriteLine("Executing PostgreSQL query: " + query);
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnecting from PostgreSQL database");
    }
}