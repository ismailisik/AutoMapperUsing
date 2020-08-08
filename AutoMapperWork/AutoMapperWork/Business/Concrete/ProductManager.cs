using AutoMapperWork.Business.Abstract;
using AutoMapperWork.DataAccess.Abstract;
using AutoMapperWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperWork.Business.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal productDal;
        public ProductManager(IProductDal _productDal)
        {
            productDal = _productDal;
        }

        public void Add(Product product)
        {
            productDal.Add(product);
        }

        public void Delete(Product product)
        {
            productDal.Delete(product);
        }

        public Product GetById(int id)
        {
            return productDal.Get(x=>x.ProductID==id);
        }

        public List<Product> GetCategoryById(int categoryId)
        {
            return productDal.GetList(x => x.CategoryID == categoryId);
        }

        public List<Product> GetList()
        {
            return productDal.GetList();
        }

        public void Update(Product product)
        {
            productDal.Update(product);
        }
    }
}
