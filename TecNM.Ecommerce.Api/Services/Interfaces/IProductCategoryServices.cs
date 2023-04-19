using TecNM.Ecommerce.Core.Dto;

namespace TecNM.Ecommerce.Api.Services.Interfaces;

public interface IProductCategoryServices
{
    
    //metodo para guardar categoria
    Task<ProductCategoryDto> SaveAsync(ProductCategoryDto category);
    
    //metodo para actualizar las categorias
    Task<ProductCategoryDto> UpdateAsync(ProductCategoryDto category);
    
    //metodo para retornar una lista de categorias
    Task<List<ProductCategoryDto>> GetAllAsync();

    Task<bool> ProductCategoryExist(int id);
    //metodo para retornar el id de las categorias que borrara
    Task<bool> DeleteAsync(int id);
    
    //metodo para obtener una categoria por id
    Task<ProductCategoryDto> GetById(int id);

}