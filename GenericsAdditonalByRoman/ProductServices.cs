using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAdditonalByRoman
{
    class ProductServices : Product, IProductService
    {
        private Product _product;
        public ProductServices(Product product)
        {
            _product = product;
        }

        public Product GetProduct()
        {
            return this;
        }

        public Product CreateProduct(Product prod)
        {
            return prod;
        }

        public Product UpdateProduct(Product prod)
        {
            return prod;
        }

        public string DeleteProduct()
        {
            return "product deleted";
        }
    }
}
