using AutoMapper;
using GeekBooking.ProductAPI.Data.ValueObjects;
using GeekShopping.ProductAPI.Model;

namespace GeekBooking.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {

            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}
