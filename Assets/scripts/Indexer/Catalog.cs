using UnityEngine;
namespace Indexer
{
    public class Catalog
    {
        public string this[int index]
        {
            get
            {
                return (index % 2 == 0) ? $"{index}�� ¦��": $"{index}�� Ȧ��";
            }
        }

    }
}