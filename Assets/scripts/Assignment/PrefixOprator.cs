using UnityEngine;

//PrefixOprator(���� ���� ������) : ���� ���ο��� �����ϴ� �켱 ������ ���� ����
public class PrefixOprator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = ++i;
        Debug.Log("j : " + j);
    }

}
