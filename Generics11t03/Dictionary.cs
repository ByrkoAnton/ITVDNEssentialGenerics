using System;
using System.Collections.Generic;
using System.Text;

namespace Generics11t03
{
    class Dictionary<TKey, TVal>
    {
        TKey[] _keys = new TKey[5];
        TVal[] _vals = new TVal[5];

        private int _emptyPoz = 0;

        public int colectionSize => _emptyPoz;

        private void IncreaseCapacity()
        {
            TKey[] newKeys = new TKey[_keys.Length * 2];
            TVal[] newVals = new TVal[newKeys.Length];

            for (int i = 0; i < _keys.Length; i++)
            {
                newKeys[i] = _keys[i];
                newVals[i] = _vals[i];
            }

            _keys = newKeys;
            _vals = newVals;
        }

        public void AddElems(TKey key, TVal val)
        {
            if (_emptyPoz == _keys.Length - 1)
                IncreaseCapacity();

            _keys[_emptyPoz] = key;
            _vals[_emptyPoz++] = val;
        }

        public string this[int idx]//буду возвращать строку т.к. нет типа данных Dictionary для возврата 1го элемента. 
        {
            get
            {
                if (idx >= _emptyPoz)
                {
                    return
                        "No elem by this idx.";
                }
                return $"Key = {_keys[idx]} Value = {_vals[idx]}";
            }
        }
    }
}
