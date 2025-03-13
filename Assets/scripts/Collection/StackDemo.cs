using System.Collections;
using UnityEngine;

public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack stack = new Stack();

        stack.Push("ù ��°");
        stack.Push("�� ��°");
        stack.Push("�� ��°");

        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
        try
        {
            Debug.Log(stack.Pop());
        }
        catch(System.Exception ex)
        {
            Debug.Log($"��������:{ex.Message}");
        }
    }
}
