using UnityEngine;
namespace Constructor
{
    public class ConstrutorDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }
    }
}
/*
Constructor(생성자) : 클래스가 사용될 떄 제일 먼저 호출되는 메서드
:인스턴스(객체)를 생성할 때 제일 먼저 호출되는 메서드
:클래스 필드의 기본값을 설정하는 역할, 필드 초기화

Constructor(생성자) 형식
: 생성자 이름이 클래스 이름과 동일하다
:public접근 제한자를 사용
:반환값도 없고 void도 없다.

:모든 클래스는 생성자를 가지고 있다
: 생성자를 만들지 않으면 기본 생성자를 자동으로 만들어준다
class ClassName(클래스 이름)
{
    //생성자 정의
    public ClassName()
    {

    }
}
 */