using UnityEngine;

//PostfixOprator(��������������): ���� ���ο��� �����ϴ� �켱 ������ ���� ����(���� ���߿� ����)
public class PostfixOprator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = x++;
        Debug.Log("x : " + x);
        Debug.Log("y : " + y);
    }

}
