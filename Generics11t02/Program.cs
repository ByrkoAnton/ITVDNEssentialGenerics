using System;

namespace Generics11t02
{
    class Program
    {
        static void Main(string[] args)
        {
           CarCollection <Car> cars = new CarCollection<Car>();
           Console.WriteLine(cars.colectionSize);
           cars.AddCar(new Car("Ford",2019));
           Console.WriteLine(cars.colectionSize);
           Car car = cars[0];
           car.ShowCarInfo();
           cars.AddCar(new Car("Ford2", 2019));
           cars.AddCar(new Car("Ford3", 2019));
           cars.AddCar(new Car("Ford4", 2019));
           cars.AddCar(new Car("Ford5", 2019));
           cars.AddCar(new Car("Ford6", 2019));
           Console.WriteLine(cars.colectionSize);
           car = cars[3];
           car.ShowCarInfo();
           cars.ClearCarCollection();
           Console.WriteLine(cars.colectionSize);


        }
    }
}
