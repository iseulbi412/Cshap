using UnityEngine;

public class ForCountdownDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 1; i < 5 + 1; i++)
        {
            Debug.Log($"증가 카운트다운:{i}");
        }
        Debug.Log("====================================");
        for(int i =5; i > 0; i--)
        {
            Debug.Log($"감소 카운트다운:{i}");
        }
    }

}
