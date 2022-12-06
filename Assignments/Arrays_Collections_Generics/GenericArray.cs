using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.Arrays_Collections_Generics
{
    public class GenericArray<T>
    {
        private readonly T[] _items;
        private readonly int _maxSize;
        public int _currentSize = 0;

        public GenericArray(int maxSize)
        {
            _maxSize = maxSize;
            _items = new T[maxSize];
        }

        public void Set(int index, T item)
        {
            if (index >= _currentSize && index < 0)
            {
                throw new ArgumentOutOfRangeException("Out of bounds");
            }
            else
            {
                _items[index] = item;
                _currentSize++;
            }
        }

        public T Get(int index)
        {
            if (index >= _currentSize && index < 0)
            {
                throw new ArgumentOutOfRangeException("Out of bounds");
            }
            else
                return _items[index];
        }

        public void SwapByIndex(int index1, int index2)
        {
            if ((index1 >= _currentSize && index1 < 0) && (index2 >= _currentSize && index2 < 0))
            {
                throw new ArgumentOutOfRangeException("Out of bounds");
            }
            else
            {
                T oldValue = _items[index1];
                _items[index1] = _items[index2];
                _items[index2] = oldValue;
            }
        }

        public void SwapByValue(T item1, T item2)
        {
            for (int i = 0; i < _currentSize; i++)
            {
                if (_items[i].Equals(item1))
                    _items[i] = item2;

                else

                if (_items[i].Equals(item2))
                    _items[i] = item1;
            }
        }

        public void SwapByIndexAndValue(int index1, T item1, int index2, T item2)
        {
            if ((index1 >= _currentSize && index1 < 0) && (index2 >= _currentSize && index2 < 0))
            {
                throw new ArgumentOutOfRangeException("Out of bounds");
            }
            else
            {
                if ((_items[index1].Equals(item1)) && (_items[index2].Equals(item2)))
                {
                    _items[index1] = item2;
                    _items[index2] = item1;
                }
            }
        }
    }
}
