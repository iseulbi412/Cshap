using UnityEngine;

//PostfixOprator(후위증감연산자): 같은 라인에서 연산하는 우선 순위가 가장 낮음(가장 나중에 연산)
public class PostfixOprator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = x++;
        Debug.Log("x : " + x);
        Debug.Log("y : " + y);
    }

}
