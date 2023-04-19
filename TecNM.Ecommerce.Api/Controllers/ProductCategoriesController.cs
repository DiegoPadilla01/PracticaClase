using Microsoft.AspNetCore.Mvc;
using TecNM.Ecommerce.Api.Repositories.Interfaces;
using TecNM.Ecommerce.Api.Services.Interfaces;
using TecNM.Ecommerce.Core.Dto;
using TecNM.Ecommerce.Core.Entities;
using TecNM.Ecommerce.Core.Http;

namespace TecNM.Ecommerce.Api.Controllers;

[ApiController]
[Route(template: "api/[controller]")]
public class ProductCategoriesController : ControllerBase
{
    
    private readonly IProductCategoryServices _productCategoryService;
    public ProductCategoriesController(IProductCategoryServices productCategoryService)
    {
        _productCategoryService = productCategoryService;
    }
    
    [HttpGet]
    public async Task<ActionResult<Response<List<ProductCategoryDto>>>> GetAll()
    {
        var response = new Response<List<ProductCategoryDto>>
        {
            Data = await _productCategoryService.GetAllAsync()
        };

        return Ok(response);
    }
    
    [HttpPost]
    public async Task<ActionResult<Response<ProductCategoryDto>>> Post([FromBody] ProductCategoryDto productCategoryDto)
    {
        var response = new Response<ProductCategoryDto>
        {
            Data = await  _productCategoryService.SaveAsync(productCategoryDto)
        };
        return Created($"/api/[controller]/{response.Data.Id}", response);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<ProductCategoryDto>>> GetById(int id)
    {
        var response = new Response<ProductCategoryDto>();
       
        if (!await _productCategoryService.ProductCategoryExist(id))
        {
            response.Errors.Add("Product Category Not Found");
            return NotFound(response);
        }
        response.Data = await _productCategoryService.GetById(id);
        return Ok(response);
   }

    [HttpPut]
    public async Task<ActionResult<Response<ProductCategoryDto>>> Update([FromBody] ProductCategoryDto productCategoryDto)
    {
                var response = new Response<ProductCategoryDto>();
       
        if (!await _productCategoryService.ProductCategoryExist(productCategoryDto.Id))
         {
             response.Errors.Add("Product Category Not Found");
             return NotFound(response);
         }

        response.Data = await _productCategoryService.UpdateAsync(productCategoryDto);
        return Ok(response);
    }
    
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<bool>>> Delete (int id)
    {
        var result = await _productCategoryService.DeleteAsync(id);
        var response = new Response<bool>();
        response.Data = result;

        return Ok(response);
    }
}