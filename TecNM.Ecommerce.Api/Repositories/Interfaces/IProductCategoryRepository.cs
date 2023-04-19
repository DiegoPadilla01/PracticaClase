using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Repositories.Interfaces;

public interface IProductCategoryRepository
{
    //metodo para guardar categoria
    Task<ProductCategory> SaveAsync(ProductCategory category);
    
    //metodo para actualizar las categorias
    Task<ProductCategory> UpdateAsync(ProductCategory category);
    
    //metodo para retornar una lista de categorias
    Task<List<ProductCategory>> GetAllAsync();

    //metodo para retornar el id de las categorias que borrara
    
    Task<bool> DeleteAsync(int id);
    
    //metodo para obtener una categoria por id
    Task<ProductCategory> GetById(int id);


}