using UnityEngine;

//+ : ���ϱ� ������ �߰� ���
public class AddtionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello" + " World!!!");
        Debug.Log("Hi" + " " + "Everyone");

        Debug.Log("123" + "456");
        Debug.Log("123" + 456);
        Debug.Log(123 + "456");
        Debug.Log(123 + 456);
        Debug.Log("123" + true);
    }

}
