using UnityEngine;
namespace Method
{
    public class PrameterRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number = 10;
            Debug.Log($"[1]: {number}");
            PrintNumber(ref number);
            Debug.Log($"[3]: {number}");
        }
        //정수형 ref number를 매개변수로 입력 받아 출력하는 함수
        void PrintNumber(ref int number)
        {
            number = 20;
            Debug.Log($"[2]: {number}");
        }
    }
}