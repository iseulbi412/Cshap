using JetBrains.Annotations;
using UnityEngine;

public class ArrayOne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] intArray;
        intArray = new int[3];

        intArray[0] = 1;
        intArray[1] = 2;
        intArray[2] = 3;
        Debug.Log($"0��° ���� ����: {intArray[0]}");
        Debug.Log($"1��° ���� ����: {intArray[1]}");
        Debug.Log($"2��° ���� ����: {intArray[2]}");
        for(int i= 0; i < 3; i++)
        {
            Debug.Log($"{i}��° ���� ����: {intArray[i]}");
        }
    }

}
