using AutoMapper;
using Core.DTO;
using Core.Entities;

namespace Infrastructure.Helpers
{
    public class ProfileMapper: Profile
    {
        public ProfileMapper()
        {
            CreateMap<ProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}
