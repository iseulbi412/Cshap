using UnityEngine;

namespace PrivatePublic
{
    //�ʵ��� ����
    public class Person
    {
        //[1]���� ������ �ʵ�
        private string name = "ȫ�浿";
        //[2]��� ������ �ʵ�
        private const int Age = 21;
        private readonly string Nickname = "������";
        private string[] address = { "����", "����", " ��õ" };
        private object obj = System.DateTime.Now.ToShortTimeString();

        public void ShowProfile()
        {
            Debug.Log($"�̸�: {name}, ����:{Age}, ����{Nickname}");
        }
    }
}
