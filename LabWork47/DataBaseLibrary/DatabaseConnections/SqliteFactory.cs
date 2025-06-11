using Microsoft.Data.Sqlite;
using System.Data;

namespace DataBaseLibrary.DatabaseConnections;

public class SqliteFactory(string connectionSting) : IDbConnectionFactory
{
    public IDbConnection CreateConnection()
        => new SqliteConnection(connectionSting);
}
