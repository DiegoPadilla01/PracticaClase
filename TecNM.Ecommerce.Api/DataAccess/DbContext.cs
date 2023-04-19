using System.Data.Common;
using MySqlConnector;
using TecNM.Ecommerce.Api.DataAccess.Interface;

namespace TecNM.Ecommerce.Api.DataAccess;

public class DbContext : IDbContext
{
    private readonly string _connectionString = 
        "server=localhost;user=root;pwd=diph01;database=practica; port=3306";
    
    private MySqlConnection _connection;

    /*public DbContext(string connectionString, MySqlConnection connection)
    {
        _connectionString = connectionString;
        _connection = connection;
    }*/

    public DbConnection Connection
    {
        get
        {
            if (_connection == null)
            {
                _connection = new MySqlConnection(_connectionString);
            }

            return _connection;
        }
    }

}