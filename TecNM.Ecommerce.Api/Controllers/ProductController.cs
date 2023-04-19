/*using Microsoft.AspNetCore.Mvc;
using TecNM.Ecommerce.Api.Repositories.Interfaces;
using TecNM.Ecommerce.Core.Entities;
using TecNM.Ecommerce.Core.Http;

namespace TecNM.Ecommerce.Api.Controllers;

[ApiController]
[Route(template: "api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductRepository _productRepository;
    
    public ProductController(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    [HttpGet]
    public async Task<ActionResult<Response<List<Product>>>> GetAll()
    {
        var products = await _productRepository.GetAllAsync();
        var response = new Response<List<Product>>();
        response.Data = products;

        return Ok(response);
    }
    [HttpPost]
    public async Task<ActionResult<Response<Product>>> Post([FromBody] Product product)
    {
        product = await _productRepository.SaveAsync(product);
        
        var response = new Response<Product>();
        response.Data = product;
        
        return Created($"/api/[controller]/{product.Id}", product);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<Product>>> GetById(int id)
    {
        var product = await _productRepository.GetById(id);
        var response = new Response<Product>();
        response.Data = product;
        
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<Response<Product>>> Update([FromBody] Product product)
    {
        var result = await _productRepository.UpdateAsync(product);
        var response = new Response<Product>{Data = result };

        return Ok(response);
    }
    
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<Product>>> Delete (int id)
    {
        var result = await _productRepository.DeleteAsync(id);
        var response = new Response<bool>();
        response.Data = result;

        return Ok(response);
    }
}*/