using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAdditonalByRoman
{
    abstract class Product:IProductService
    {
        protected int _productId;
        protected string _productType;
        protected int _productPrise;

        protected Product(int productId, string productType, int productPrise)
        {
            _productId = productId;
            _productType = productType;
            _productPrise = productPrise;
        }

        public abstract string GetProductInfo();
        public abstract Product CreateProduct(Product prod);
        public abstract Product UpdateProduct(Product prod);
        public abstract Product DeleteProduct();
    }
}
