using UnityEngine;
namespace Constructor
{
    public class Money
    {
        //기본생성자
        public Money() : this(1000)
        {
            Debug.Log("기본 생성자 실행");
        }
        //매개변수가 있는 생성자 
        public Money(int gold)
        {
            Debug.Log($"Money:{gold:#,###}");
        }
        
    }
}