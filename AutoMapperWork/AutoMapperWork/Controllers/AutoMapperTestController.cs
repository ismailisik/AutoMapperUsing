using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapperWork.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperWork.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoMapperTestController : ControllerBase
    {
        private IProductService productService;
        public AutoMapperTestController(IProductService _productService)
        {
            productService = _productService;
        }

        [HttpGet("getProducts")]
        public IActionResult GetProductList()
        {
            var result = productService.GetList();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}