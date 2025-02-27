using UnityEngine;

public class VariableValue : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //a,b,c값 초기화: 선언시 값을 대입하지 않은 상태에서 처음으로 값을 저장할 때 초기화
        int a, b, c;
        a = 10;
        b = 10;
        c = 10;
        Debug.Log(a + " " + b + " " + c);
    }

}
