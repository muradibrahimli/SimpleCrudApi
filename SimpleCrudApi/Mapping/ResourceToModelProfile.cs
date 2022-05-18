using AutoMapper;
using SimpleCrudApi.Domain.Models;
using SimpleCrudApi.Resources;

namespace SimpleCrudApi.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveProductResource, Product>();
        }
    }
}