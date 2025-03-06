using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 1;
        switch (x)
        {
            case 1:
                Debug.Log("x는 1입니다");
                break;
            case 2:
                Debug.Log("x는 2입니다");
                break;

        }
        Debug.Log("프로그램 종료");
    }

}
