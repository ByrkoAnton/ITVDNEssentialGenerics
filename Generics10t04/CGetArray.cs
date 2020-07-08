using System;
using System.Collections.Generic;
using System.Text;

namespace Generics10t04
{
    static class CGetArray
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] arr = new T[list.GetLenght];
            for (int i = 0; i < list.GetLenght; i++)
                arr[i] = list[i];
            
            return arr;
        }
    }
}
