using UnityEngine;
using System.Collections;
namespace GenericClass
{
    public class GenericClas<T>
    {
        private T[] values;
        private int _length;

        public int Length
        {
            get { return _length; }
        }
        public GenericClas (int length)
        {
            this._length = length;
            values = new T[length];
        }
        public T this[int index]
        {
            get { return values[index]; }
            set { values[index] = value; }
        }

        public IEnumerator GetEnumerator()
        {
            for(int i =0;i<_length; i++)
            {
                yield return values[i];
            }
        }
    }
}