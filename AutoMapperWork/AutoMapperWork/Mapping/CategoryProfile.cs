using AutoMapper;
using AutoMapperWork.Dto;
using AutoMapperWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperWork.Mapping
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            //Not
            /*
             * Peki benim Dto classım ile main classımın propları arasında isim farklılıkları olursa nasıl maplerim aşağıdaki gibi...
             */

            CreateMap<Category, CategoryDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.CategoryID))
                .ForMember(dest => dest.KategoriAdi, opt => opt.MapFrom(x => x.CategoryName))
                .ForMember(dest => dest.Acıklama, opt => opt.MapFrom(x => x.Description)).ReverseMap();
        }
    }
}
