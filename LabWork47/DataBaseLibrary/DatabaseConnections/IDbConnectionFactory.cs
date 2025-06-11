using System.Data;

namespace DataBaseLibrary.DatabaseConnections;

public interface IDbConnectionFactory
{
    IDbConnection CreateConnection();
}
