using System;
using System.Collections;

namespace Generics11tAdditional
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();//вроде не столкнулся с проблемами
            list.Add(5);
            list.Add(2.4);
            list.Add("hello");
            list.Add("hello3");
            list.Add("hello2");
            list.Add(645);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
