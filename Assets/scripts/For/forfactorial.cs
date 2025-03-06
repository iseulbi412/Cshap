using UnityEngine;

public class forfactorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int fact = 1;
        for(int i = 1; i < 4 + 1; i++)
        {
            fact = fact * i;
        }
        Debug.Log($"값은{fact}입니다.");
    }
}
