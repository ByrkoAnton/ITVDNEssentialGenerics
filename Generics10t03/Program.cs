using System;

namespace Generics10t03
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> myDictionary = new MyDictionary<string>();
            Console.WriteLine(myDictionary.GetLenght);

            Console.WriteLine(myDictionary[0]);
            myDictionary.AddElem("pen","ручка");
            Console.WriteLine(myDictionary[1]);
            Console.WriteLine(myDictionary[0]);


        }
    }
}
