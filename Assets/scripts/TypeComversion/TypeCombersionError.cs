using UnityEngine;
//TypeCOmbersion(���ĺ�ȯ)

public class TypeCOmbersion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]long�� ������ l�� �����ϰ� long�� ������ ���� �� �ִ� ���� ū�� �����Ѵ�
        long l = long.MaxValue;
        Debug.Log("l�ǰ� : " + l);//�ܼ�â�� ����϶�
        //[2] int�� ���� i �� �����ϰ� l���� �����Ѵ�
        int i = (int)l;
        Debug.Log("i�� ��:" + i);
    }

}
