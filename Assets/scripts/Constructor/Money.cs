using UnityEngine;
namespace Constructor
{
    public class Money
    {
        //�⺻������
        public Money() : this(1000)
        {
            Debug.Log("�⺻ ������ ����");
        }
        //�Ű������� �ִ� ������ 
        public Money(int gold)
        {
            Debug.Log($"Money:{gold:#,###}");
        }
        
    }
}