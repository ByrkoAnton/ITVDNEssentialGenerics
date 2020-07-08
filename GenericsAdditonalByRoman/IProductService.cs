using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAdditonalByRoman
{
    interface IProductService
    {
        string GetProductInfo();
        Product CreateProduct(Product prod);
        Product UpdateProduct(Product prod);
        Product DeleteProduct();

    }
}
