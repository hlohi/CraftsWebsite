using ContosoCrafts.WebSite.Services;
using ContosoCraftsWebsite.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoCraftsWebsite.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }
        
        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get([FromQuery] string Product,[FromQuery] int Rating)
        {
            return ProductService.GetProducts();
        }

    }
}
