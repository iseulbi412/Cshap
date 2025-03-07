using UnityEngine;

public class ContinueFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i =1; i <= 5; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            
            Debug.Log(i);
            
            
        }
    }
}
