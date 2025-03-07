using UnityEngine;

public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 0;
        while (true)
        {
            Debug.Log(number);
            number++;
            if(number >= 5)
            {
                break;
            }
        }
    }

}
