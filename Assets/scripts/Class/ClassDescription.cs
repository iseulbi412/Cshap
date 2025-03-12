using UnityEngine;

public class ClassDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Run();  //메서드 호출 : 같은 클래스의 메서드 호출
        ClassDescription.Run(); //클래스 레벨의 메서드 호출 :  클래스이름.메서드() 호출
    }
    static void Run()
    {
        Debug.Log("ClassDescription라는 클래스의 Run 매서드");
    }
}
