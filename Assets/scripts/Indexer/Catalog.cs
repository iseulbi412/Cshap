using UnityEngine;
namespace Indexer
{
    public class Catalog
    {
        public string this[int index]
        {
            get
            {
                return (index % 2 == 0) ? $"{index}´Â Â¦¼ö": $"{index}´Â È¦¼ö";
            }
        }

    }
}