using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Week2API.Entities.Concrete;

namespace Week2API.Business.Absract
{
    public interface IProductService
    {
        List<Product> GetAll(Expression<Func<Product, bool>> filter);
        Product GetEntity(Expression<Func<Product, bool>> filter);
        void Add(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
