using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 4;
        if (number % 2 ==0)
        {
            Debug.Log("짝수입니다.");
        }
        else
        {
            Debug.Log("홀수입니다.");
        }
        if (number % 3 == 0)
        {
            Debug.Log($"{number}는 3의 배수");
        }
        else if (number % 5 == 0)
        {
            Debug.Log($"{number}는 5의 배수");
        }
        else if (number % 7 == 0)
        {
            Debug.Log($"{number}는 7의 배수");
        }
        else
        {
            Debug.Log($"{number}은 3, 5, 7,의 배수가 아니다");
        }
    }

}
