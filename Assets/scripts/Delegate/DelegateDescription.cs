using UnityEngine;
namespace Delegate
{
    public class DelegateDiscription : MonoBehaviour
    {
        delegate void SayDelegate();

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            SayDelegate say = Hi;
            say();
            SayDelegate hello = new SayDelegate(Hi);
            hello();
            SayDelegate insa = new SayDelegate(Hi);
            insa.Invoke();
        }
        void Hi()
        {
            Debug.Log("안녕하세요");
        }
    }
}
/*
Delegate(대리자, 대신 실행자)
등록(지정)한 메서드를 대신 실행시켜주는 놈
매개변수 목록 및 반환 형식이 있는 메서드를 참조로 나타내는 형식

Delegate형식 - 매개변수도 없고, 반환형도 없는 메서드를 대신 실행해주는 대리자
delegate void (대리자 이름)
 */