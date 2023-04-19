using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Repositories.Interfaces;

public interface IProductRepository
{
    //metodo para guardar producto
    Task<Product> SaveAsync(Product product);
    
    //metodo para actualizar las producto
    Task<Product> UpdateAsync(Product product);
    
    //metodo para retornar una lista de producto
    Task<List<Product>> GetAllAsync();

    //metodo para retornar el id de las producto que borrara
    Task<bool> DeleteAsync(int id);
    
    //metodo para obtener una producto por id
    Task<Product> GetById(int id);
}