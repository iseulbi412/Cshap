using UnityEngine;

public class WhileSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;
        int i = 1;
        while (i <= n)
        {
            if (i % 2 == 0)
            {
                sum =+ i;
            }
            
            i++;

        }
        Debug.Log($"гую╨{sum}");
    }
}
