using System;
using System.Collections.Generic;
using System.Text;

namespace Generics11t02
{
    class Car
    {
        private string _name { get; set; }
        private int _year { get; set; }

        public Car(string name, int year)
        {
            _name = name;
            _year = year;
        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Model {_name}\nYear {_year}");
        }
    }
}
