using UnityEngine;

public class ForSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i, sum = 0;
        for (i = 0; i < 10 + 1; i = i + 2)
        {
            sum = sum + i;
        }
        Debug.Log($"гую╨ {sum}");
    }

}
