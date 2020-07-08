using System;

namespace Generics10t02
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList=new MyList<int>();
            Console.WriteLine(myList.GetLenght);
            myList.AddElem(5);
            Console.WriteLine(myList.GetLenght);
            myList.AddElem(10);
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList.GetLenght);
            Console.WriteLine(myList[1]);


        }
    }
}
