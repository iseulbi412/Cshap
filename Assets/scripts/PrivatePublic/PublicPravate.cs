using UnityEngine;
namespace PrivatePublic
{
    public class PublicPravate
    {
        public static string name = "Ʈ��";
        private int age;
        //���� �޼���
        //�̸��� ��ȯ�ϴ� �Խ�
        public static string GetName()
        {
            return name;
        }
        public void SetAge (int nai)
        {
            age = nai;
        }
        public int GetAge()
        {
            return age;
        }
    }
}