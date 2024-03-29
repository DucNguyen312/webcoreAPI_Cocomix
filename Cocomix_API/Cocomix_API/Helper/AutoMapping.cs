﻿using AutoMapper;
using Cocomix_API.DataReponse;
using Cocomix_API.DTO;
using Cocomix_API.Models;

namespace Cocomix_API.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping() 
        {
            //Product
            CreateMap<Product, ProductReponse>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
         
            //Category
            CreateMap<Category, CategoryReponse>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();

            //Customer
            CreateMap<Customer , CustomerReponse>().ReverseMap();
            CreateMap<Customer , CustomerDTO>().ReverseMap();

            //Order
            CreateMap<Order , OrderDTO>().ReverseMap();
            CreateMap<Order , DataOrderDTO>().ReverseMap();
        }
    }
}
