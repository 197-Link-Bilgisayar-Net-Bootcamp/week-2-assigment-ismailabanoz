﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2API.Entities.Concrete;

namespace Week2API.DataAccess.Concrete.EntityFramework
{
    public class Week2Context : DbContext
    {
        
        public DbSet<Product> Products { get; set; }
    }
}
