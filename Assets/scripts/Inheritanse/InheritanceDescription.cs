using UnityEngine;
namespace Inheritance
{
    public class InheritanceDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

            Child child = new Child();
            child.Foo();
            child.Bar();
        }
    }
}
/*
Inheritance(���):�θ�Ŭ������ �ڽ��� ����� �ڽ� Ŭ�������� �����־ ����ϵ��� �ϴ� ��
�θ�Ŭ����: BaseŬ����, ����Ŭ����, �⺻ Ŭ���� - �ڽ� Ŭ������ ������ ���� �� �ִ�
�ڽ� Ŭ�������� ���� ����� ��� ���� Ŭ����
�ڽ�Ŭ����:SubŬ����
����Ŭ����:�ڽ��� �ڽ� Ŭ���� - �θ�+�ڽ�Ŭ������ ����� ��� ���� �޴´�
 */