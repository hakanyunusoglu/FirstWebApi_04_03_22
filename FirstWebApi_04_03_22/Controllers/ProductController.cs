using FirstWebApi_04_03_22.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FirstWebApi_04_03_22.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("LoadProductList")]
        public List<ProductDto> LoadProductList()
        {
            List<ProductDto> resultlist = new List<ProductDto>();
        for(int i=1;i<=100;i++)
            {
                ProductDto product = new ProductDto()
                {
                    ProductID = i,
                    Brand = i + ".marka",
                    Description = i + ".ürün açıklaması"
                };
                resultlist.Add(product);
            }
            return resultlist;
        }
    }
}
