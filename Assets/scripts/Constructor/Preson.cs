using PrivatePublic;
using UnityEngine;
namespace Constructor 
{
public class Person
{
        //[1]�ʵ�
        private string name;
        //[2] ������ - �Ű����� x
        public Person()
        {
            name = "ȫ�浿";
        }
        //[3]������ - �Ű������� �̸� �Է¹޴´�
        public Person(string _name)
        {
            name = _name;
        }
        //[4]�޼���  private�� �̸��� public�� �޼���� �ܺο��� ��� �����ϵ��� �Ѵ�
        public string Getname()
        {
            return name;
        }
}
}