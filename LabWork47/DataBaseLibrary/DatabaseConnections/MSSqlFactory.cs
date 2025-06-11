using Microsoft.Data.SqlClient;
using System.Data;

namespace DataBaseLibrary.DatabaseConnections;

public class MSSqlFactory(string connectionSting) : IDbConnectionFactory
{
    public IDbConnection CreateConnection()
        => new SqlConnection(connectionSting);
}
