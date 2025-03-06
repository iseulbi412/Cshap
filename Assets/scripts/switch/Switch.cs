using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*int answer = 5;
        switch (answer)
        {
            case 1:
                Debug.Log("1번 답을 선택했습니다");
                break;
            case 2:
                Debug.Log("2번 답을 선택했습니다");
                break;
            case 3:
                Debug.Log("3번 답을 선택했습니다");
                break;
            case 4:
                Debug.Log("4번 답을 선택했습니다");
                break;
            default:
                Debug.Log("잘못선택하였습니다.");
                break;
        }*/
        int answer = 5;
        if (answer == 1)
        {
            Debug.Log("1번 답을 선택했습니다");
            
        }
        else if (answer == 2)
            {
            Debug.Log("2번 답을 선택했습니다");
        }
        else if (answer == 3)
            {
            Debug.Log("3번 답을 선택했습니다");
        }
        else if (answer == 4)
            {
            Debug.Log("4번 답을 선택했습니다");
        }
        else
        {
            Debug.Log("잘못선택하였습니다.");
        }
    }

}
