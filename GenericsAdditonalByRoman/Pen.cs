using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace GenericsAdditonalByRoman
{
    class Pen: ProductServices
    {
        private string _mecanism { get; set; }
        private int _lineThicknessMM { get; set; }

        public Pen(int productId, string productType, int productPrise, int lineThicknessMm, string mecanism) 
        {
            _lineThicknessMM = lineThicknessMm;
            _mecanism = mecanism;
            _productId = productId;
            _productType = productType;
            _productPrise = productPrise;
        }
    }
}
