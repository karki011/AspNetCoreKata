using System;
using System.Collections;
using System.Collections.Generic;

namespace AspNetCoreKata.Shared
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
    }
   
}
