using AutoMapperWork.Core.Repository.Concrete;
using AutoMapperWork.DataAccess.Abstract;
using AutoMapperWork.DataAccess.EntityFramework.Context;
using AutoMapperWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperWork.DataAccess.Concrete
{
    public class CategoryDal:EfBaseRepository<Category,NorthwindContext>,ICategoryDal
    {
    }
}
