using UnityEngine;
using System.Collections;
public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack stack = new Stack();
        stack.Push("대한민국");
        stack.Push("서울특별시");
        stack.Push("강동구");

        Debug.Log($"{stack.Peek()},{stack.Count}");

        stack.Pop();
        Debug.Log($"{stack.Peek()},{stack.Count}");
        if(stack.Count > 0)
        {
            stack.Pop();
            Debug.Log($"{stack.Peek()},{stack.Count}");
        }

        stack.Clear();
        Debug.Log($"{stack.Count}");
    }
}
