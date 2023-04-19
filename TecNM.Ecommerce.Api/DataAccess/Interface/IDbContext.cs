using System.Data.Common;

namespace TecNM.Ecommerce.Api.DataAccess.Interface;

public interface IDbContext
{
    DbConnection Connection { get; }
}