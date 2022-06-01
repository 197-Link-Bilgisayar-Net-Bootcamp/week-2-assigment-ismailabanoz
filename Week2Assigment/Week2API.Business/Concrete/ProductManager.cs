using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Week2API.Business.Absract;
using Week2API.DataAccess.Abstract;
using Week2API.Entities.Concrete;

namespace Week2API.Business.Concrete
{
    //Single-responsibility principle
    //Open-closed principle
    //Liskov substitution principle
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter)
        {
            return _productDal.GetAll(filter);
        }


        public Product GetEntity(Expression<Func<Product, bool>> filter)
        {
            return _productDal.GetEntity(filter);
        }



        public void Update(Product product)
        {
            _productDal.Update(product);
        }

    }
}
