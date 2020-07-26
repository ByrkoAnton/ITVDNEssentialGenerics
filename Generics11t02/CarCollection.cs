using System;
using System.Collections.Generic;
using System.Text;

namespace Generics11t02
{
    class CarCollection <T>
    {
        T[] cars = new T[5];
        private int _emptyPoz = 0;

        public int colectionSize => _emptyPoz;

        private void IncreaseCapacity()
        {
            T[] newCars = new T[cars.Length*2];

            for (int i = 0; i < cars.Length; i++)
            {
                newCars[i] = cars[i];
            }

            cars = newCars;
        }

        public T this[int idx]
        {
            get
            {
                if (idx >= _emptyPoz)
                {
                    Console.WriteLine("No elem by this idx. Will return last ");
                    return cars[_emptyPoz - 1];
                }
                    
                return cars[idx];
            }
        }
        public void AddCar(T car)
        {
            if (_emptyPoz == cars.Length-1)
                IncreaseCapacity();

            cars[_emptyPoz++] = car;
        }

        public void ClearCarCollection()
        {
            cars = new T[5];
            _emptyPoz = 0;
        }
    }
}
