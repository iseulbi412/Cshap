using UnityEngine;
//ecrememtOprator(���ҿ�����):������ ������ ���� 1 ����
public class DecrememtOprator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = -100;
        --num;
        Debug.Log("num" + num);
    }

}
