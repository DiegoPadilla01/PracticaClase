using Microsoft.AspNetCore.Mvc;
using TecNM.Ecommerce.Api.Services;
using TecNM.Ecommerce.Api.Services.Interfaces;
using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.Core.Http;

namespace TecNM.Ecommerce.Api.Controllers;

[ApiController]
[Route(template: "api/[controller]")]
public class CategoryController  : ControllerBase
{
     private readonly ICategoryServices _categoryService;
    public CategoryController(ICategoryServices categoryService)
    {
        _categoryService = categoryService;
        
    }
    
    [HttpGet]
    public async Task<ActionResult<Response<List<CategoryDto>>>> GetAll()
    {
        var response = new Response<List<CategoryDto>>
        {
            Data = await _categoryService.GetAllAsync()
        };

        return Ok(response);
    }
    
    [HttpPost]
    public async Task<ActionResult<Response<CategoryDto>>> Post([FromBody] CategoryDto categoryDto)
    {
        var response = new Response<CategoryDto>
        {
            Data = await  _categoryService.SaveAsync(categoryDto)
        };
        return Created($"/api/[controller]/{response.Data.Id}", response);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<CategoryDto>>> GetById(int id)
    {
        var response = new Response<CategoryDto>();
       
        if (!await _categoryService.CategoryExist(id))
        {
            response.Errors.Add("Product Category Not Found");
            return NotFound(response);
        }
        response.Data = await _categoryService.GetById(id);
        return Ok(response);
   }

    [HttpPut]
    public async Task<ActionResult<Response<CategoryDto>>> Update([FromBody] CategoryDto categoryDto)
    {
                var response = new Response<CategoryDto>();
       
        if (!await _categoryService.CategoryExist(categoryDto.Id))
         {
             response.Errors.Add("Product Category Not Found");
             return NotFound(response);
         }

        response.Data = await _categoryService.UpdateAsync(categoryDto);
        return Ok(response);
    }
    
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<bool>>> Delete (int id)
    {
        var result = await _categoryService.DeleteAsync(id);
        var response = new Response<bool>();
        response.Data = result;

        return Ok(response);
    }
}