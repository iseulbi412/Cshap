using UnityEngine;

public class Car : MonoBehaviour
{
    public string name;
    private int age;
    string address;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Hi()
    {
        Debug.Log("안녕하세요.");  
    }
    private void Bye()
    {
        Debug.Log("안녕히 계세요");
        
    }
    //private한 필드를 외부에 공개하고자 할떄 public한 메서드를 사용
    //매게변수로 나이를 입력받아 age에 저장하는 함수
    public void SetAge(int iAge)
    {
        age = iAge;
    }
    //age를 반환하는 함수
    public int GetAge()
    {
        return age;
    }
    void Start()
    {


    }
}
