using UnityEngine;

public class Min : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = { -2, -5, -3, -7, -1 };

        int minValue = FindMinValue(numbers);

        Debug.Log("배열의 최소값: " + minValue);
    }

 
    int FindMinValue(int[] arr)
    {
        int min = arr[0]; 

        foreach (int num in arr)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }
}

