using UnityEngine;
//�� ���� �������� �����ϴ� ����ü
//[1] ����ü ����, ����
struct BusinessCard
{
    public string name; //���̸�
    public int age; //�� ����
    public string address; //�� �ּ�
}
public class StructNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BusinessCard MyCard;
        //[3]����ü�� �����ִ� �����͵��� �ʱ�ȭ
        MyCard.name = "ȫ�浿";
        MyCard.age = 20;
        MyCard.address = "����� ������";
        //[4]����ü ���
        Debug.Log($"�̸�{MyCard.name},����:{MyCard.age},�ּ�:{MyCard.address}");
    }
}
