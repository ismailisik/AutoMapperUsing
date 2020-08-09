using AutoMapperWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperWork.Dto
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string KategoriAdi { get; set; }
        public string Acıklama { get; set; }
    }
}
