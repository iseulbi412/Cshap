using UnityEngine;
namespace Constructor
{
    public class ConstrutorNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //personŬ������ �ν��Ͻ� ����
            //[1]�Ű� ������ ���� �⺻ ������ ȣ��
            Person saram1 = new Person();
            Debug.Log(saram1.Getname());
            Person saram2 = new Person();
            Debug.Log(saram2.Getname());
            //[2]�Ű� ������ �ִ� ������ ȣ��
            Person person1 = new Person("��λ�");
            Debug.Log(person1.Getname());
            Person person2 = new Person("����");
            Debug.Log(person2.Getname());
        }
    }
}