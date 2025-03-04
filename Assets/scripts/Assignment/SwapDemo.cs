using UnityEngine;

public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;
        int temp;

        Debug.Log($"처음에는 i: {i} j : {j}");
        //자리 바꾸기
        temp = i; //임시 변수에 i값 저장
        i = j;//i변수에 j 값 저장
        j = temp;// j 변수에 임시변수에 저장되었던 i 값을 지정
        Debug.Log($"나중값에는 i: {i} j : {j}");
    }

}
