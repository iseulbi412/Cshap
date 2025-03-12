using UnityEngine;

//정적 메서드 호출, 인스턴스 메서드 호출
public class MyFristClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]정적 메서드 호출 : 클래스이름.메서드이름()
        ClassMember.StaticMethod();
        //[2]인스턴스 메서드 호출
        //호출방법
        //클래스의 객체(게체,Instance)생성-(클래스에 변수 선언)
        //new 키워드를 이용하여 새로운 객체 생성
        //(클래스 이름) 객체 이름 = new 클래스이름();
        //(객체이름).메서드 이름
        ClassMember member = new ClassMember();
        member.InstanceMethod();

    }
}
