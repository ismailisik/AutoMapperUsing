using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapperWork.Business.Abstract;
using AutoMapperWork.Dto;
using AutoMapperWork.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoMapperTestController : ControllerBase
    {
        private IProductService productService;
        private ICategoryService categoryService;
        private IMapper mapper;
        public AutoMapperTestController(IProductService _productService, IMapper _mapper, ICategoryService _categoryService)
        {
            productService = _productService;
            mapper = _mapper;
            categoryService = _categoryService;
        }

        [HttpGet("getProducts")]
        public IActionResult GetProductList()
        {
            var result =  productService.GetList();
          
            if (result != null)
            {
                //Not: Benim dbm den gelen product datalarını direkt dto şeklinde dönüştürüp dışarı açıyor. Bakınız(Mapping/ProductProfile)
                return Ok(mapper.Map<List<ProductDto>>(result));
            }
            return BadRequest();
        }

        [HttpGet("getCategories")]
        public IActionResult GetCategories()
        {
            var result = categoryService.GetList();
            if (result != null)
            {
                //Not: Burada main class ile dto classı arasında prop isim farklılığı olduğunda nasıl mapleriz onun örneğini yaptık. Bakınız(Mapping/CategoryProfile)
                return Ok(mapper.Map<List<CategoryDto>>(result));
            }
            return BadRequest();
        }

        [HttpGet("getProductInfo")]
        public IActionResult GetProductInfo()
        {
            var result = productService.GetProductInfo();
            if (result != null)
            {
                //Bu Kısımda Entitymiz içerisindeki complex type ları nasıl dto muz içerisindeki prop lara mapleriz onu yaptık. Bakınız(Mapping/ProductProfile)
                return Ok(mapper.Map<List<ProductInfoDto>>(result));
            }
            return BadRequest();
        }

        [HttpPost("addDate")]
        public IActionResult GetDate(Date time)
        {
            //Burada Projection işlemi yaptık bir prop'u dto muz daki birden çok prop ile mapledik. Bakınız(Mapping/DateProfile)
            return Ok(mapper.Map<DateDto>(time));
        }

        [HttpPost("addDateDto")]
        public IActionResult GetDateDto(DateDto time)
        {
            //Yukarıdaki işlemin tam tersini yaptık. Bakınız(Mapping/DateProfile)
            return Ok(mapper.Map<Date>(time));
        }

    }
}