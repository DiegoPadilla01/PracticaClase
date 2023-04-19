using TecNM.Ecommerce.Core.Dto;

namespace TecNM.Ecommerce.Api.Services.Interfaces;

public interface ICategoryServices
{
    Task<CategoryDto> SaveAsync(CategoryDto category);
    
    //metodo para actualizar las categorias
    Task<CategoryDto> UpdateAsync(CategoryDto category);
    
    //metodo para retornar una lista de categorias
    Task<List<CategoryDto>> GetAllAsync();

    Task<bool> CategoryExist(int id);
    //metodo para retornar el id de las categorias que borrara
    Task<bool> DeleteAsync(int id);
    
    //metodo para obtener una categoria por id
    Task<CategoryDto> GetById(int id);

}