using AutoMapper;
using ECommerceTestAPI.Model;
using ECommerceTestAPI.ModelsDTO;
using System.Drawing;
using System.Runtime;

namespace ECommerceTestAPI.MapperConfiguration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Product,ProductDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>()
               .ForMember(dest => dest.CategoryId,
               opts => opts.MapFrom(src => src.Category.PK_CatId));
            CreateMap<Category,CategoryDTO>().ReverseMap();
            CreateMap<Attributes,AttributesDTO>().ReverseMap();
        }
    }
}
