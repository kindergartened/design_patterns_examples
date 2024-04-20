namespace SimpleDesignPatterns.Strategy.IDatabases;

public interface INoSqlDatabase : IDatabase
{
    void Connect();
    void Query(string query);
    void Disconnect();
}