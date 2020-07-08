﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAdditonalByRoman
{
    class Services:IProductService
    {
        private Product _product;
        public Services(Product product)
        {
            _product = product;
        }
        public Product ProductServises(Product product)
        {
            return product;
        }
        public string GetProductInfo()
        {
            return _product.GetProductInfo();
        }

        public Product CreateProduct(Product prod)
        {
            return _product.CreateProduct(prod);
        }

        public Product UpdateProduct(Product prod)
        {
            return _product.UpdateProduct(prod);
        }

        public Product DeleteProduct()
        {
            return _product.DeleteProduct();
        }
    }
}
