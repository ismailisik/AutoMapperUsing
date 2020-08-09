using AutoMapperWork.Core.Repository.Concrete;
using AutoMapperWork.DataAccess.Abstract;
using AutoMapperWork.DataAccess.EntityFramework.Context;
using AutoMapperWork.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AutoMapperWork.DataAccess.Concrete
{
    public class ProductDal : EfBaseRepository<Product, NorthwindContext>, IProductDal
    {
        public List<Product> GetProductInfo()
        {
            using (var context = new NorthwindContext())
            {
                return context.Products.Include("Category").Include("Supplier").ToList();
            }
        }
    }
}
