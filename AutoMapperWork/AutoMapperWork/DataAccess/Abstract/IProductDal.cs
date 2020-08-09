using AutoMapperWork.Core.Repository.Abstract;
using AutoMapperWork.Entities;
using System.Collections.Generic;

namespace AutoMapperWork.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        public List<Product> GetProductInfo();
    }
}
