using UnityEngine;
namespace Indexer
{
    public class IndexerDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Person person = new Person();
            person[0] = "홍길동";
            Debug.Log(person[0]);
            person[1] = "백두산";
            Debug.Log(person[1]);
            Debug.Log(person[0]);
        }
    }
}