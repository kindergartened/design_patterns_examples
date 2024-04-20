namespace SimpleDesignPatterns.Strategy.IDatabases;

public interface ISqlDatabase : IDatabase
{
    void Connect();
    void Query(string query);
    void Disconnect();
}