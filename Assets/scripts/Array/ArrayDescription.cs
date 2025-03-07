using UnityEngine;

public class ArrayDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int[] numbers;

        numbers = new int[n];

        numbers[0] = 3840;
        numbers[1] = 2160;
        Debug.Log(numbers[0] * numbers[1] * numbers[2]);
    }

}
