using AutoMapper;
using AutoMapperWork.Dto;
using AutoMapperWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace AutoMapperWork.Mapping
{
    public class DateProfile : Profile
    {
        public DateProfile()
        {
            CreateMap<Date, DateDto>()
                .ForMember(dest => dest.Year, opt => opt.MapFrom(x => x.date.Year))
                .ForMember(dest => dest.Month, opt => opt.MapFrom(x => x.date.Month))
                .ForMember(dest => dest.Day, opt => opt.MapFrom(x => x.date.Day));

            CreateMap<DateDto, Date>()
                .ForMember(dest => dest.date, opt => opt.MapFrom(x => new DateTime(x.Year, x.Month, x.Day)));
        }
    }
}
