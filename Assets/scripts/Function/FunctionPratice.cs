using Unity.Mathematics;
using UnityEngine;

public class FunctionPratice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result;
        result = Add(5, 3);
        Debug.Log(result);

        result = Substract(5, 3);
        Debug.Log(result);

        result = Multiply(5, 3);
        Debug.Log(result);

        result = Devide(5, 3);
        Debug.Log(result);

        result = Remainder(5, 3);
        Debug.Log(result);
    }
    int Add(int x, int y)
    {
        return x + y;
    }
    int Substract(int x, int y) => x - y;
    int Multiply(int x, int y) =>x* y;
    int Devide(int x, int y) => x / y;
    int Remainder(int x, int y) => x % y;
}
/*
��Ģ������ ���ϴ� �Լ� �����
+,-,*,/,%

�ΰ��� ������ �Է¹޾� ����Ͽ� ������� ��ȯ�ϴ� �Լ� �����
�Է°� 5, 3
[output]

 */