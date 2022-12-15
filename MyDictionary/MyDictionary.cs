using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
     internal class MyDictionary<TKey,TValue> // generic class
    {
        TKey[] _key;
        TValue[] _Value;
        public MyDictionary()
        {
            _key = new TKey[0];
            _Value = new TValue[0];
        }
        public void Add(TKey key,TValue value)
        {
            TKey[] tempKeyArray = _key;
            TValue[] tempValueArray = _Value;
            _key = new TKey[_key.Length + 1];
            _Value = new TValue[_Value.Length + 1];
            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                _key[i] = tempKeyArray[i];
            }
            for (int i = 0; i < tempValueArray.Length; i++)
            {
                _Value[i] = tempValueArray[i];
            }
            _key[_key.Length - 1] = key;
            _Value[_Value.Length - 1] = value;


        }
        public int Count
        {
            get { return _key.Length; }
        }
            
    }
}
