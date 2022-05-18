using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleCrudApi.Domain.Models;

namespace SimpleCrudApi.Persistence.Contexts
{
    public static class SeedData
    {
        public static async Task Seed(AppDbContext context)
        {
            var products = new List<Product>
            {
                new()
                {
                    Id = 100,
                    Name = "Apple"
                },
                new()
                {
                    Id = 101,
                    Name = "Milk"
                }
            };
            context.Products.AddRange(products);
            await context.SaveChangesAsync();
        }
    }
}