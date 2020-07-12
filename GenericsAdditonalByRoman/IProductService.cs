using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAdditonalByRoman
{
    interface IProductService

    {
        Product GetProduct();
        Product CreateProduct(Product prod);
        Product UpdateProduct(Product prod);
        string DeleteProduct();

    }
}
