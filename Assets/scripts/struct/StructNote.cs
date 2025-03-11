using UnityEngine;
//고객 명함 데이터의 관리하는 구조체
//[1] 구조체 정의, 선언
struct BusinessCard
{
    public string name; //고객이름
    public int age; //고객 나이
    public string address; //고객 주소
}
public class StructNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BusinessCard MyCard;
        //[3]구조체에 속해있는 데이터들의 초기화
        MyCard.name = "홍길동";
        MyCard.age = 20;
        MyCard.address = "서울시 강동구";
        //[4]구조체 사용
        Debug.Log($"이름{MyCard.name},나이:{MyCard.age},주소:{MyCard.address}");
    }
}
