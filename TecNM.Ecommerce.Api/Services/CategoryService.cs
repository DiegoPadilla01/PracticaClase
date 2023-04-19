using TecNM.Ecommerce.Api.Repositories.Interfaces;
using TecNM.Ecommerce.Api.Services.Interfaces;
using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Services;

public class CategoryService : ICategoryServices
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public async Task<CategoryDto> SaveAsync(CategoryDto categoryDto)
    {
        var category = new Category
        {
            Name = categoryDto.Name,
            Description = categoryDto.Description,
            CreatedBy = DateTime.Now,
            CreatedDate = DateTime.Now,
            UpdatedBy = DateTime.Now,
            UpdatedDate = DateTime.Now

        };
        category = await _categoryRepository.SaveAsync(category);
        category.Id = category.Id;
        return categoryDto;
    }

    public async Task<CategoryDto> UpdateAsync(CategoryDto categoryDto)
    {
        var category = await _categoryRepository.GetById(categoryDto.Id);
        if (category == null)
            throw new Exception("Product Category Not Found");
        category.Name = category.Name;
        category.Description = category.Description;
        category.UpdatedBy = DateTime.Now;
        category.UpdatedDate = DateTime.Now;
        await _categoryRepository.UpdateAsync(category);

        return categoryDto;
    }

    public async Task<List<CategoryDto>> GetAllAsync()
    {
        var categories = await _categoryRepository.GetAllAsync();
        var categoriesDto = categories.Select(c => new CategoryDto(c)).ToList();
        return categoriesDto;
    }

    public async Task<bool> CategoryExist(int id)
    {
       var category = await  _categoryRepository.GetById(id);
                return (category != null);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        return await _categoryRepository.DeleteAsync(id);
        //return (category != null);
    }

    public async Task<CategoryDto> GetById(int id)
    {
        var category = await _categoryRepository.GetById(id);
        if (category != null)
            throw new Exception("Product Category Not Found");
        var categoryDto = new CategoryDto(category);
        return categoryDto;
    }
}