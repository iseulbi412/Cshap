using UnityEngine;

public class CoutinueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;
        for(int i = 1; i <= n; i++)
        {
            if(i % 3 == 0)
            {
                continue;
            }
            sum += i;
            
        }
        Debug.Log(sum);
    }

}
