using UnityEngine;

//중첩 구조체: 구조체안에 구조체
//성적을 관리하는 구조체 만들기
//과목의 점수를 관리하는 구조체 선언
struct Score
{
    public int kor;
    public int eng;
}
//학생 정보 관리하는 구조체 선언 - 성적 포함
struct Student
{
    public int number;
    public string name;
    public Score scores;
}
public class StructPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]학생 구조체 배열 변수 선언 및 요소수 생성
        Student[] students = new Student[3];
        students[0].number = 1;
        students[0].name = "홍길동";
        students[0].scores.kor = 100;
        students[0].scores.eng = 90;

        students[1].number = 2;
        students[1].name = "백두산";
        students[1].scores.kor = 90;
        students[1].scores.eng = 80;

        students[2].number = 3;
        students[2].name = "임꺽정";
        students[2].scores.kor = 90;
        students[2].scores.eng = 75;

        //[3]학생 구조체 사용 - 성적표 출력

        for (int i = 0; i < students.Length; i++)
        {
            Debug.Log($"{students[i].number}-{students[i].name} : 국어{students[i].scores.kor},{students[i].scores.eng}");
        }
    }

}
