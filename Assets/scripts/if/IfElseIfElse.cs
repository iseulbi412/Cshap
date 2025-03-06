using UnityEngine;

public class IfElseIfElse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number1 =10, number2 = 10;

        if (number1 > number2)
        {
            Debug.Log("number1이 큽니다");
        }
        else if(number1 < number2)
        {
            Debug.Log("number2이 큽니다");
        }
        else
        {
            Debug.Log("두 수가 같습니다.");
        }
    }

}
