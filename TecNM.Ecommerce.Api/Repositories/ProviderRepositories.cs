using TecNM.Ecommerce.Api.Repositories.Interfaces;
using TecNM.Ecommerce.Core.Entities;

namespace TecNM.Ecommerce.Api.Repositories;

public class ProviderRepositories : IProviderRepository
{
    public Task<Provider> SaveAsync(Provider provider)
    {
        throw new NotImplementedException();
    }

    public Task<Provider> UpdateAsync(Provider provider)
    {
        throw new NotImplementedException();
    }

    public Task<List<Provider>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Provider> GetById(int id)
    {
        throw new NotImplementedException();
    }
}