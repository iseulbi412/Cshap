using UnityEngine;

public class ArrayOne2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1-1]int[] intArray = new int[3] { 1,2,3 };
        //[1-2]int[] intArray = new int[] { 1, 2, 3, 4 };
        //[1-3]
        int[] intArray = { 1, 2, 3, 4 };
        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"{i}번째 방의 값은: {intArray[i]}");
        }
    }

}
