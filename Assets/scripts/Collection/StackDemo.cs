using System.Collections;
using UnityEngine;

public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack stack = new Stack();

        stack.Push("첫 번째");
        stack.Push("두 번째");
        stack.Push("세 번째");

        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        try
        {
            Debug.Log(stack.Pop());
        }
        catch(System.Exception ex)
        {
            Debug.Log($"에러내용:{ex.Message}");
        }
    }
}
