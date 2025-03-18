using UnityEngine;
namespace Constructor
{
    public class ConstrutorNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //person클래스의 인스턴스 생성
            //[1]매개 변수가 없는 기본 생성자 호출
            Person saram1 = new Person();
            Debug.Log(saram1.Getname());
            Person saram2 = new Person();
            Debug.Log(saram2.Getname());
            //[2]매개 변수가 있는 생성자 호출
            Person person1 = new Person("백두산");
            Debug.Log(person1.Getname());
            Person person2 = new Person("장길산");
            Debug.Log(person2.Getname());
        }
    }
}