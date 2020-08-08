using AutoMapperWork.Core.Repository.Abstract;
using AutoMapperWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperWork.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
