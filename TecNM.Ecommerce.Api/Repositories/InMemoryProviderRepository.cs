using TecNM.Ecommerce.Api.Repositories.Interfaces;
using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Repositories;

public class InMemoryProviderRepository : IProviderRepository
{
    private readonly List<Provider> _providers;

    public InMemoryProviderRepository()
    {
        _providers = new List<Provider>();
    }
    public async Task<Provider> SaveAsync(Provider providery)
    {
        providery.Id = _providers.Count +1;

        _providers.Add(providery);

        return providery;    
    }

    public async Task<Provider> UpdateAsync(Provider providery)
    {
        var index = _providers.FindIndex(x => x.Id == providery.Id);
        if(index != -1)
            _providers[index] = providery;
        return await Task.FromResult(providery);    }

    public async Task<List<Provider>> GetAllAsync()
    {
        return _providers;

    }

    public async Task<bool> DeleteAsync(int id)
    {
        _providers.RemoveAll(x => x.Id == id);

        return true;
    }

    public async Task<Provider> GetById(int id)
    {
        //que obtenga el primero, pide una condicion. 
        var provider = _providers.FirstOrDefault(x => x.Id == id);
        
        return await Task.FromResult(provider);
        
    }
}