using UnityEngine;

public class IsDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 1234;
        object o = i;
        Debug.Log(o);
        object obj = 9874;
        int num = (int)obj;
        Debug.Log(num);

        object s = "안녕하세요";
        object j = 4567;

        if(s is string)
        {
            Debug.Log($"[1]{s}는 null이 아니며 문자열 형식으로 변환이 가능합니다");
        }
        if(j is int)
        {
            Debug.Log($"[2]{j}는 정수형으로 변환이 가능합니다.");
        }
    }
}
/*
Is 연산자: 형식 비교하기
-특정 형식인지 아닌지를 비교
-특정 형식으로 변환이 가능하면 true, 그렇지 않으면 false

박싱(boxing) : 값 형식의 데이터를 참조 형식의 데이터로 변경하는것
언박싱(unboxing):참조 형식의 데이터를 값 형식의 데이터로 변경 - 캐시팅, 캐스트
 */
