using UnityEngine;

public class intToByte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int형 변수를 x로 선언하고 225로 초기화
        int x = 255;
        //byte형 변수 y를 선언하고 x의 값으로 초기화
        //byte 저장범위: 0~255 
        byte y = (byte)x;
        Debug.Log(x + "->" + y);


    }

}
