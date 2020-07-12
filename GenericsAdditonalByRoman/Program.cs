using System;

namespace GenericsAdditonalByRoman
{
    class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car(1,"Car","BMW","X5",60000);
           car.GetProduct();
           IProductService productService = new ProductServices(car);
           
           

           Console.WriteLine(productService.GetProduct());
           Product pen = productService.CreateProduct(new Pen(2, "pen", 20, 2, "roller"));
           Console.WriteLine(pen.GetProduct());
           //productService = productService.UpdateProduct(pen);
           Console.WriteLine(productService.GetProductInfo());
           productService.DeleteProduct();
           Console.WriteLine(productService.GetProductInfo());


        }
    }
}
