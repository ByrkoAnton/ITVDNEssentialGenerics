using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace GenericsAdditonalByRoman
{
    class Pen: Product
    {
        private string _mecanism;
        private int _lineThicknessMM;
        public Pen(int productId, string productType, int productPrise, int lineThicknessMm, string mecanism) : base(productId, productType, productPrise)
        {
            _lineThicknessMM = lineThicknessMm;
            _mecanism = mecanism;
        }

        public override string GetProductInfo()
        {
            return $"Id {_productId}\nType {_productType}\nMecanism {_mecanism}\nLineThicknessMM {_lineThicknessMM}\n" +
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
            _mecanism = null;
            _lineThicknessMM = 0;
            _productPrise = 0;
            _productType = null;

            return this;
        }
    }
}
