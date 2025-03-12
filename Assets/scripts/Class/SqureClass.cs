using UnityEngine;

public class SqureClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Squre클래스의 정적(static) 메서드 GetNAme 호출
        string name = Squre.GetName();
        Debug.Log(name);
    }

}
