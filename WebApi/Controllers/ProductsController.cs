using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System.Collections.Generic;
using System.Linq;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        [Route("GetAll")]
        public IDataResult<List<Product>> GetAll()
        {
            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Log(LogLevel.Info, $"Loglama çalıştı.");
            return _productService.GetAll();
            //if (result.Success)
            //{
            //    return Ok();
            //}
            //return BadRequest();
        }
        [HttpPost]
        [Route("AddProduct")]
        public IActionResult AddProduct(Product product)
        {
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok();
            }
            return BadRequest();



        }
    }
}
