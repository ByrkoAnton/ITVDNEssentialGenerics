using System;

namespace GenericsAdditonalByRoman
{
    class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car(1,"Car","BMW","X5",60000);
           car.GetProductInfo();
           IProductService productService = new Services(car);

           Console.WriteLine(productService.GetProductInfo());
           Product pen = productService.CreateProduct(new Pen(2, "pen", 20, 2, "roller"));
           Console.WriteLine(pen.GetProductInfo());
           productService = productService.UpdateProduct(pen);
           Console.WriteLine(productService.GetProductInfo());
           productService.DeleteProduct();
           Console.WriteLine(productService.GetProductInfo());


        }
    }
}
