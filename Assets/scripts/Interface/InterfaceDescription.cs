using UnityEngine;
namespace Interface
{
    public class InterfaceDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ICar icar = new ICar();
            Car car = new Car();
            car.Go();
        }
    }
}
/*
Interface(인터페이스) : 상속  받은 자식 클래스가 특정 멤버를 반드시 구현되어야 함을 보증
상속받은 자식클래스가 특정 멤버를 구현하도록 강제한다
인터페이스의 이름 작명시 맨 앞에있는 문자는 대문자 I를 붙인다
 */