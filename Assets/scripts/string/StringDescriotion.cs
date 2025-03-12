using UnityEngine;

//String 클래스,StringBuilder클래스를 이용하여 문자열 다루기
public class StringDescriotion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 관련 메서드 - 대문자, 소문자, 바꾸기
        string message = "hello World!";
        Debug.Log(message);

        //[1]대문자
        Debug.Log(message.ToUpper());
        Debug.Log(message.ToLower());
        Debug.Log(message.Replace("hello","안녕하세요").Replace("World","세계"));
    }
}
