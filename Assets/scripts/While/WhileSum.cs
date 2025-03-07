using UnityEngine;

public class WhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0;
        int i = 1;
        while(i <= n)
        {
            sum = sum + i;
            i++;

        }
        Debug.Log($"гую╨{sum}");
    }

}
