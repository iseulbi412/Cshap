using UnityEngine;

//���� �޼��� ȣ��, �ν��Ͻ� �޼��� ȣ��
public class MyFristClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]���� �޼��� ȣ�� : Ŭ�����̸�.�޼����̸�()
        ClassMember.StaticMethod();
        //[2]�ν��Ͻ� �޼��� ȣ��
        //ȣ����
        //Ŭ������ ��ü(��ü,Instance)����-(Ŭ������ ���� ����)
        //new Ű���带 �̿��Ͽ� ���ο� ��ü ����
        //(Ŭ���� �̸�) ��ü �̸� = new Ŭ�����̸�();
        //(��ü�̸�).�޼��� �̸�
        ClassMember member = new ClassMember();
        member.InstanceMethod();

    }
}
