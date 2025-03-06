using UnityEngine;

public class ForSunPratice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i, sum = 0;
        for (i = 0; i < 100+1 + 1; i = i++)
        {
            if (i % 3 == 0 ||i % 4 == 0)
            {
                sum += i;
            }
        }

        Debug.Log("1부터 100까지의 정수 중에서 3의 배수 또는 4의 배수의 합: " + sum);
    }
            
    
}
