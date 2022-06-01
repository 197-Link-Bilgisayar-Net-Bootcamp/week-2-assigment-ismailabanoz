using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2API.Entities.Concrete;

namespace Week2API.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
