using UnityEngine;

public class AttayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { 1, 2, 3, 4 };
        int index = 0;

        Debug.Log(numbers[index++]);
        Debug.Log(numbers[index++]);
        Debug.Log(numbers[index++]);

        Debug.Log(numbers[--index]);
        Debug.Log(numbers[--index]);
        Debug.Log(numbers[--index]);
    }
}
