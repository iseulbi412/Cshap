using System.Collections;
using UnityEngine;

public class QueueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Queue queue = new Queue();

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());
        Debug.Log(queue.Dequeue());
    }
}
