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
        // performs data retrieval
        [HttpGet]
        public IActionResult Get()
        {
            //var products = _productDal.GetAll();
            //return Ok(products);

            var product = new Product { Id = 1, ProductName = "Monitör", Price = 5000, Stock = 25 };
            return Ok(product);
        }
        // Returns the product whose id is given
                [HttpGet("{productId}")]
        public IActionResult Get(int productId)
        {
            //var product=_productDal.GetEntity(p => p.Id == productId);
            //return Ok(product);

            return Ok(productId);

        }
        //the product is saved
        [HttpPost]
        public IActionResult Save(Product product)
        {
            //_productDal.Add(new Product { Price = 3445,ProductName="23452345sdfgsdf",Stock=30 });
            return Ok(product);
        }
        // the product is updated
        [HttpPut]
        public IActionResult Update(Product product)
        {
            return Ok(product);
        }
        //the product is deleted
        [HttpDelete("{productId}")]
        public IActionResult Delete(int productId)
        {
            return Ok(productId);
        }
    }
}
