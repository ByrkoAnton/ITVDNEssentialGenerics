using System;

namespace Generics10t02
{
    class MyList<T>
    {
        private T[] _myList;

        public void AddElem(T elem)
        {
            if (_myList != null)
            {
                var newList = new T[_myList.Length + 1];
                for (int i = 0; i < _myList.Length; i++)
                {
                    newList[i] = _myList[i];
                }

                newList[^1] = elem;
                _myList = newList;
            }

            else
            {
                _myList = new[] { elem };
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < _myList.Length)
                    return _myList[index];

                Console.WriteLine(
                    $"Попытка обращения за пределы массива. Возвращается последний элемент - [{_myList.Length - 1}]");
                return _myList[_myList.Length - 1];
            }
        }

        public int GetLenght
        {
            get
            {
                if (_myList != null)
                    return _myList.Length;
                return 0;
            }
        }
    }
}
