using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace DataAccess;

public class BaseDAL
{
    public DataProvider dataProvider { get; set; } = null;

    public SqlConnection connection = null;
    //--------------------------------

    public BaseDAL()
    {
        var connectionString = GetConnectionString();
        dataProvider = new DataProvider(connectionString);
    }
    //-------------------------
    public string GetConnectionString()
    {
        string connectionString;
        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        connectionString = config["ConnectionString:FStore"];
        return connectionString;
    }

    public void CloseConnection() => dataProvider.CloseConnecction(connection);
}
