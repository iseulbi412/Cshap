using UnityEngine;
//AssignmentOperator(할당(대입)연산자)-변수에 값을 저장한다
public class AssignmentOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = "홍길동";
        int age = 19;
        Debug.Log($"이름은 {name} 나이는 {age}입니다.");
 
    }

}
