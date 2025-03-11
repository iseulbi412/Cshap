using UnityEngine;
//���丮�� ���ϴ� �˰���(4!)
public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(4 * 3 * 2 * 1);
        Debug.Log(Factorial4(4));
        Debug.Log(Factorial(4));

    }
    int Factorial4(int n)
    {
        int result = 1;
        for(int i= 1; i <= n; i++)
        {
            result = result * i;
        }
        return result;
    }
    int Factorial (int n)
    {
        if (n == 1 || n==0)
        {
            return 1;
        }
        return n*Factorial(n-1);

    }
    /*����Լ�:�Լ��� �ڽ��� �ڵ� ��� �ȿ��� �ڱ� �ڽ��� �ٽ� ȣ���ϴ� �Լ�
-����Լ� �Ű�����: �Ű������� ����, ������ �ȴ�.
-����Լ� �ڵ� ��Ͼȿ��� ����Լ��� ������ �� �ִ� ������ �ʿ��ϴ�

 */
}
