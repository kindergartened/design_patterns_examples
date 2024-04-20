namespace SimpleDesignPatterns.Strategy;

public interface IDatabase
{
    void Connect();
    void Query(string query);
    void Disconnect();
}