using UnityEngine;

public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 1;
        switch (x)
        {
            case 1:
                Debug.Log("x�� 1�Դϴ�");
                break;
            case 2:
                Debug.Log("x�� 2�Դϴ�");
                break;

        }
        Debug.Log("���α׷� ����");
    }

}
