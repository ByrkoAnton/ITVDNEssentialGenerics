using System;
using System.Collections.Generic;
using System.Text;

namespace Generics10t03
{
    class MyDictionary<T>
    {
        private T[] _key;
        private T[] _val;

        public void AddElem(T key, T val)
        {
            if (_key != null)
            {
                var newKey = new T[_key.Length + 1];
                var newVal = new T[_val.Length + 1];

                for (int i = 0; i < _key.Length; i++)
                {
                    newKey[i] = _key[i];
                    newVal[i] = _val[i];
                }

                newKey[^1] = key;
                newVal[^1] = val;

                _key = newKey;
                _val = newVal;
            }

            else
            {
                _key = new[] { key };
                _val = new[] { val };
            }
        }

        public string this[int index]
        {
            get
            {
                if (GetLenght==0)
                    return "Empty";
                if (index < _key.Length)
                    return _key[index].ToString() +" "+ _val[index].ToString();

                return
                    "Попытка обращения за пределы массива";
            }
        }

        public int GetLenght
        {
            get
            {
                if (_key != null)
                    return _key.Length;
                return 0;
            }
        }
    }
}
