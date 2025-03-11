using UnityEngine;

public class MethodOverloadDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hi();
        Hi("반갑습니다");
        Hi("감사합니다",3);
    }
    void Hi()
    {
        Debug.Log("안녕하세요");
    }
    void Hi(string message)
    {
        Debug.Log(message);
    }
    void Hi(string message, int count)
    {
        for(int i = 0; i < count; i++)
        {
            Debug.Log(message);
        }
    }

}
