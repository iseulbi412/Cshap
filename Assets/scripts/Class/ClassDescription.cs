using UnityEngine;

public class ClassDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Run();  //�޼��� ȣ�� : ���� Ŭ������ �޼��� ȣ��
        ClassDescription.Run(); //Ŭ���� ������ �޼��� ȣ�� :  Ŭ�����̸�.�޼���() ȣ��
    }
    static void Run()
    {
        Debug.Log("ClassDescription��� Ŭ������ Run �ż���");
    }
}
