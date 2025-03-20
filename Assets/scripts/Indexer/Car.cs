using UnityEngine;
using System.Collections;
namespace Indexer
{
    public class Car
    {
        private string[] names;

        public Car(int length)
        {
            names = new string[length];
        }
        public int Length
        {
            get { return names.Length; }
        }
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < names.Length; i++)
            {
                yield return names[i];
            }
        }
    }
}