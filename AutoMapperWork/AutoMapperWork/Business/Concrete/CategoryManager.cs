using AutoMapperWork.Business.Abstract;
using AutoMapperWork.DataAccess.Abstract;
using AutoMapperWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperWork.Business.Concrete
{
    public class CategoryManager :ICategoryService
    {
        private ICategoryDal categoryDal;
        public CategoryManager(ICategoryDal _categoryDal)
        {
            categoryDal = _categoryDal;
        }

        public void Add(Category category)
        {
            categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            categoryDal.Delete(category);
        }

        public Category GetById(int id)
        {
            return categoryDal.Get(x => x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return categoryDal.GetList();
        }

        public void Update(Category category)
        {
            categoryDal.Update(category);
        }
    }
}
