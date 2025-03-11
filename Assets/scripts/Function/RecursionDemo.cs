using UnityEngine;
//팩토리얼 구하는 알고리즘(4!)
public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(4 * 3 * 2 * 1);
        Debug.Log(Factorial4(4));
        Debug.Log(Factorial(4));

    }
    int Factorial4(int n)
    {
        int result = 1;
        for(int i= 1; i <= n; i++)
        {
            result = result * i;
        }
        return result;
    }
    int Factorial (int n)
    {
        if (n == 1 || n==0)
        {
            return 1;
        }
        return n*Factorial(n-1);

    }
    /*재귀함수:함수가 자신의 코드 블록 안에서 자기 자신을 다시 호출하는 함수
-재귀함수 매개변수: 매개변수는 감산, 가산이 된다.
-재귀함수 코드 블록안에는 재귀함수를 종료할 수 있는 조건이 필요하다

 */
}
