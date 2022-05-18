using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleCrudApi.Domain.Models;
using SimpleCrudApi.Domain.Services.Communication;

namespace SimpleCrudApi.Domain.Services
{
    public interface IProductService
    {
         Task<IEnumerable<Product>> ListAsync();
         Task<ProductResponse> SaveAsync(Product product);
         Task<ProductResponse> UpdateAsync(int id, Product product);
         Task<ProductResponse> DeleteAsync(int id);
    }
}