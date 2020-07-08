using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAdditonalByRoman
{
    class Car : Product
    {
        private string _manufacturer;
        private string _model;
        

        public Car(int productId, string productType, string manufacturer, string model, int productPrise) : base(productId, productType, productPrise)
        {
            _manufacturer = manufacturer;
            _model = model;
        }

        public override string GetProductInfo()
        {
            return $"Id {_productId}\nType {_productType}\nManufacturer {_manufacturer}\nModel {_model}\n" +
                   $"Prise {_productPrise}\n";
        }

        public override Product CreateProduct(Product prod)
        {
            return prod;
        }

        public override Product UpdateProduct(Product prod)
        {
            return prod;
        }

        public override Product DeleteProduct()
        {
            _manufacturer = null;
            _model = null;
            _productPrise = 0;
            _productType = null;

            return this;
        }
    }
}
