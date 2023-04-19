/*using Microsoft.AspNetCore.Mvc;
using TecNM.Ecommerce.Api.Repositories.Interfaces;
using TecNM.Ecommerce.Core.Entities;
using TecNM.Ecommerce.Core.Http;

namespace TecNM.Ecommerce.Api.Controllers;

[ApiController]
[Route(template: "api/[controller]")]
public class ProviderController : ControllerBase
{
    private readonly IProviderRepository _providerRepository;
    
    public ProviderController(IProviderRepository providerRepository)
    {
        _providerRepository = providerRepository;
    }
    [HttpGet]
    public async Task<ActionResult<Response<List<Product>>>> GetAll()
    {
        var providers = await _providerRepository.GetAllAsync();
        var response = new Response<List<Provider>>();
        response.Data = providers;

        return Ok(response);
    }
    [HttpPost]
    public async Task<ActionResult<Response<Provider>>> Post([FromBody] Provider providery)
    {
        providery = await _providerRepository.SaveAsync(providery);
        
        var response = new Response<Provider>();
        response.Data = providery;
        
        return Created($"/api/[controller]/{providery.Id}", providery);
    }

    [HttpGet]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<Provider>>> GetById(int id)
    {
        var providery = await _providerRepository.GetById(id);
        var response = new Response<Provider>();
        response.Data = providery;

        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<Response<Provider>>> Update([FromBody] Provider providery)
    {
        var result = await _providerRepository.UpdateAsync(providery);
        var response = new Response<Provider>{Data = result };

        return Ok(response);
    }
    
    [HttpDelete]
    [Route("{id:int}")]
    public async Task<ActionResult<Response<Provider>>> Delete (int id)
    {
        var result = await _providerRepository.DeleteAsync(id);
        var response = new Response<bool>();
        response.Data = result;

        return Ok(response);
    }
}*/