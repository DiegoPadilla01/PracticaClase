using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Repositories.Interfaces;

public interface ICategoryRepository
{
    Task<Category> SaveAsync(Category category);
    
    //metodo para actualizar las categorias
    Task<Category> UpdateAsync(Category category);
    
    //metodo para retornar una lista de categorias
    Task<List<Category>> GetAllAsync();

    //metodo para retornar el id de las categorias que borrara
    
    Task<bool> DeleteAsync(int id);
    
    //metodo para obtener una categoria por id
    Task<Category> GetById(int id);
}