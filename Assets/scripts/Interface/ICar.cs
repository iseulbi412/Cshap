using UnityEngine;
namespace Interface
{
    public interface ICar
    {
        void Go();
    }
    public class Car : ICar
    {
        public void Go()
        {
            Debug.Log("상속한 인터페이스의 정의된 모든 멤버를 반드시 구현해야 한다.");
        }
    }
}