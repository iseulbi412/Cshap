using UnityEngine;

public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;
        int temp;

        Debug.Log($"ó������ i: {i} j : {j}");
        //�ڸ� �ٲٱ�
        temp = i; //�ӽ� ������ i�� ����
        i = j;//i������ j �� ����
        j = temp;// j ������ �ӽú����� ����Ǿ��� i ���� ����
        Debug.Log($"���߰����� i: {i} j : {j}");
    }

}
