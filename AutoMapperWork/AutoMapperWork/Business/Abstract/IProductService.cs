using AutoMapperWork.DataAccess.Abstract;
using AutoMapperWork.Entities;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperWork.Business.Abstract
{
    public interface IProductService
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetList();
        Product GetById(int id);
        List<Product> GetCategoryById(int categoryId);
        List<Product> GetProductInfo();
    }
}
