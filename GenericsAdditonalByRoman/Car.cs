using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsAdditonalByRoman
{
    class Car : ProductServices
    {
        private string _manufacturer { get; set; }
        private string _model { get; set; }



        public Car(int productId, string productType, string manufacturer, string model, int productPrise) : base()
        {
            _manufacturer = manufacturer;
            _model = model;
            _productId = productId;
            _productType = productType;
            _productPrise = productPrise;
        }
    }
}
