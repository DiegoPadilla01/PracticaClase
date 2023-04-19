using TecNM.Ecommerce.Api.Repositories.Interfaces;
using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Repositories;

public class InMemoryProductRepository : IProductRepository
{
    private readonly List<Product> _product;

    public InMemoryProductRepository()
    {
        _product = new List<Product>();
    }
    public async Task<Product> SaveAsync(Product producty)
    {
        producty.Id = _product.Count +1;

        _product.Add(producty);

        return producty;    }

    public async Task<Product> UpdateAsync(Product producty)
    {
        var index = _product.FindIndex(x => x.Id == producty.Id);
        if(index != -1)
            _product[index] = producty;
        return await Task.FromResult(producty);    
    }

    public async Task<List<Product>> GetAllAsync()
    {
        return _product;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        _product.RemoveAll(x => x.Id == id);

        return true;    }

    public async Task<Product> GetById(int id)
    {
        //que obtenga el primero, pide una condicion. 
        var producty = _product.FirstOrDefault(x => x.Id == id);
        
        return await Task.FromResult(producty);
    }
}