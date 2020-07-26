using System;

namespace Generics11t03
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            Console.WriteLine(dictionary.colectionSize);

            dictionary.AddElems(1, "1111");
            dictionary.AddElems(2, "222");
            dictionary.AddElems(3, "333");
            dictionary.AddElems(4, "444");
            dictionary.AddElems(5, "555");
            dictionary.AddElems(6, "6");
            Console.WriteLine(dictionary[0]);
            Console.WriteLine(dictionary.colectionSize);

        }
    }
}
