using AutoMapper;
using AutoMapperWork.Dto;
using AutoMapperWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperWork.Mapping
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            //Not
            /*
             * ProductProfile class AutoMapper' dan gelen Profile class' ından kalıtıyoruz. Maplame işlemi ctor' da yapılıyor..
             */

            //CreateMap<Product, ProductDto>();  // Product ile ProductDto yu mapple
            //CreateMap<ProductDto, Product>();  // ProductDto ile Product yu mapple

            //Yukarıdaki yaptığımızın kısa hali 
            CreateMap<Product, ProductDto>().ReverseMap(); //Tersi için de geçerli kıl maplame işlemini..

            //Complex Tiplerin Maplenmesi İşlemi

            //Bu complex tiplerin maplemenin uzun versiyonu
            //CreateMap<Product, ProductInfoDto>()
            //    .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(x => x.Category.CategoryName))
            //    .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(x => x.Supplier.CompanyName))
            //    .ForMember(dest => dest.Address, opt => opt.MapFrom(x => x.Supplier.Address))
            //    .ForMember(dest => dest.City, opt => opt.MapFrom(x => x.Supplier.City));

            //Kısa Versiyonu

            //Not: InqludeMember methodu kullanılmadan önce complex tipler ile Dto muz ile bir mapleme işlemi yapmamız gerekmektedir.
            CreateMap<Category, ProductInfoDto>();
            CreateMap<Supplier, ProductInfoDto>();

            //Not: InqludeMembers methodu sayesinde Category ve Supplier complex verilerimizi Dto muz içerisindeki prop lar ile mapleyebiliriz.

            CreateMap<Product, ProductInfoDto>().IncludeMembers(x => x.Category).IncludeMembers(x=>x.Supplier);
        }
    }
}
