using UnityEngine;
namespace Delegate
{
    public class DelegateDiscription : MonoBehaviour
    {
        delegate void SayDelegate();

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            SayDelegate say = Hi;
            say();
            SayDelegate hello = new SayDelegate(Hi);
            hello();
            SayDelegate insa = new SayDelegate(Hi);
            insa.Invoke();
        }
        void Hi()
        {
            Debug.Log("�ȳ��ϼ���");
        }
    }
}
/*
Delegate(�븮��, ��� ������)
���(����)�� �޼��带 ��� ��������ִ� ��
�Ű����� ��� �� ��ȯ ������ �ִ� �޼��带 ������ ��Ÿ���� ����

Delegate���� - �Ű������� ����, ��ȯ���� ���� �޼��带 ��� �������ִ� �븮��
delegate void (�븮�� �̸�)
 */