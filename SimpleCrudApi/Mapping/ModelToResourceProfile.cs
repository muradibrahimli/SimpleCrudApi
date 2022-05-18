using AutoMapper;
using SimpleCrudApi.Domain.Models;
using SimpleCrudApi.Resources;

namespace SimpleCrudApi.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Product, ProductResource>();
        }
    }
}