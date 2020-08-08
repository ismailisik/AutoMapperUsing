using AutoMapperWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperWork.Business.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
        List<Category> GetList();
        Category GetById(int id);
    }
}
