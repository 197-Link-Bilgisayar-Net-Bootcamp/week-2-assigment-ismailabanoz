using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week2API.DataAccess.Abstract;
using Week2API.Entities.Concrete;

namespace Week2API.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductDal _productDal;
        public ProductsController(IProductDal productDal)
        {
            _productDal = productDal;
        }
        [HttpGet]
        public IActionResult Get()
        {
            //var products = _productDal.GetAll();
            //return Ok(products);

            var product = new Product { Id = 1, ProductName = "Monitör", Price = 5000, Stock = 25 };
            return Ok(product);
        }
        [HttpGet("{productId}")]
        public IActionResult Get(int productId)
        {
            //var product=_productDal.GetEntity(p => p.Id == productId);
            //return Ok(product);

            return Ok(productId);

        }
        [HttpPost]
        public IActionResult Save(Product product)
        {
            return Ok(product);
        }

        [HttpPut]
        public IActionResult Update(Product product)
        {
            return Ok(product);
        }
        [HttpDelete("{productId}")]
        public IActionResult Delete(int productId)
        {
            return Ok(productId);
        }
    }
}
