using System.Collections;
using UnityEngine;

public class StackClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Stack st = new Stack();
        st.Push("First");
        st.Push("Second");

        //���ÿ��� ������ ������ : Pop
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());

    }
}
