using UnityEngine;

public class Dowhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        do
        {
            Debug.Log("�ȳ��ϼ���");
            i++;
        } while (i < 3);
    }

}
