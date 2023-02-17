using AutoMapper;
using RetailShop.Models;
using RetailShop.Repositary.Entity;

namespace RetailShop.Services.Implementation
{
    public class ProductMap : Profile
    {
        public ProductMap()
        {
            CreateMap<Product, ModelProduct>().ReverseMap();
            CreateMap<Order, ModelOrder>().ReverseMap();    
        }

    }
}
