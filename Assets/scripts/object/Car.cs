using UnityEngine;

public class Car : MonoBehaviour
{
    public string name;
    private int age;
    string address;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Hi()
    {
        Debug.Log("�ȳ��ϼ���.");  
    }
    private void Bye()
    {
        Debug.Log("�ȳ��� �輼��");
        
    }
    //private�� �ʵ带 �ܺο� �����ϰ��� �ҋ� public�� �޼��带 ���
    //�ŰԺ����� ���̸� �Է¹޾� age�� �����ϴ� �Լ�
    public void SetAge(int iAge)
    {
        age = iAge;
    }
    //age�� ��ȯ�ϴ� �Լ�
    public int GetAge()
    {
        return age;
    }
    void Start()
    {


    }
}
