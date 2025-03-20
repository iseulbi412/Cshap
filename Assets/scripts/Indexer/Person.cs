using UnityEngine;
namespace Indexer
{
    public class Person
    {
        private string name;

        public string this[int index]
        {
            get { return name; }
            set { name = value; }
        }
    }
}