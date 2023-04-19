using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Repositories.Interfaces;

public interface IProviderRepository
{
    //metodo para guardar proveedor
    Task<Provider> SaveAsync(Provider provider);
    
    //metodo para actualizar los proveedor
    Task<Provider> UpdateAsync(Provider provider);
    
    //metodo para retornar una lista de categorias
    Task<List<Provider>> GetAllAsync();

    //metodo para retornar el id de los proveedor que borrara
    Task<bool> DeleteAsync(int id);
    
    //metodo para obtener un proveedor por id
    Task<Provider> GetById(int id);

}