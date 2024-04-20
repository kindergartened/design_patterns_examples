using SimpleDesignPatterns.Strategy.DB;
using SimpleDesignPatterns.Strategy.IDatabases;

namespace SimpleDesignPatterns.Strategy;

public class Context
{
    private IDatabase _databaseStrategy;

    public Context(DatabaseType type)
    {
        switch (type)
        {
            case DatabaseType.Mongo:
                _databaseStrategy = new MongoDatabase();
                break;
            case DatabaseType.Postgres:
                _databaseStrategy = new PostgresDatabase("");
                break;
            default:
                _databaseStrategy = new SqliteDatabase("Data Source=../../../../sqlite.db;Version=3;");
                break;
        }
    }

    public void ExecuteQuery(string query)
    {
        _databaseStrategy.Connect();

        if (_databaseStrategy is ISqlDatabase sqlStrategy)
        {
            var database = sqlStrategy;
            database.Query(query);
        }
        else if (_databaseStrategy is INoSqlDatabase noSqlStrategy)
        {
            var database = noSqlStrategy;
            database.Query(query);
        }

        _databaseStrategy.Disconnect();
    }
}
