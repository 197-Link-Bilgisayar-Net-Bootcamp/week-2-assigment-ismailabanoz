using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2API.DataAccess.Abstract;
using Week2API.Entities.Concrete;

namespace Week2API.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, Week2Context>, IProductDal
    {




    }
}
