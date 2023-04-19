using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Core.Dto;

public class CategoryDto : DtoBase
{
    public string Name { get; set; }
    public string Description { get; set; }

    public CategoryDto()
    {
        
    }
    public CategoryDto(Category category)
    {
        Name = category.Name;
        Description = category.Description;
        Id = category.Id;
    }
}