using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 4;
        if (number % 2 ==0)
        {
            Debug.Log("¦���Դϴ�.");
        }
        else
        {
            Debug.Log("Ȧ���Դϴ�.");
        }
        if (number % 3 == 0)
        {
            Debug.Log($"{number}�� 3�� ���");
        }
        else if (number % 5 == 0)
        {
            Debug.Log($"{number}�� 5�� ���");
        }
        else if (number % 7 == 0)
        {
            Debug.Log($"{number}�� 7�� ���");
        }
        else
        {
            Debug.Log($"{number}�� 3, 5, 7,�� ����� �ƴϴ�");
        }
    }

}
