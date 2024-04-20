using SimpleDesignPatterns.Strategy.IDatabases;

namespace SimpleDesignPatterns.Strategy;

public class MongoDatabase : NoSqlDatabase, INoSqlDatabase
{
    public override void Query(string query)
    {
        Console.WriteLine("Executing MongoDB query: " + query);
    }
}