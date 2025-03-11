using UnityEngine;

struct Point
{
    public int x;
    public int y;

}
public class StructDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Point p;
        p.x = 100;
        p.y = 200;
        Debug.Log($"x:{p.x},y:{p.y}");
    }
}
/*
struct(구조체):하나의 이름으로 서로 다른 데이터들, 또는 함수들을 묶어서 관리하는 그릇(데이터 구조)
:사용자정의 데이터 형식


//구조체 형식
struct(구조체 이름)
    //서로 다른 형식의 데이터들
    //함수들
 */
