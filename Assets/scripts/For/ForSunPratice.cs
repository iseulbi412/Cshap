using UnityEngine;

public class ForSunPratice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i, sum = 0;
        for (i = 0; i < 100+1 + 1; i = i++)
        {
            if (i % 3 == 0 ||i % 4 == 0)
            {
                sum += i;
            }
        }

        Debug.Log("1���� 100������ ���� �߿��� 3�� ��� �Ǵ� 4�� ����� ��: " + sum);
    }
            
    
}
