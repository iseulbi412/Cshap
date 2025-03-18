using UnityEngine;
namespace Constructor
{
    public class ContstrutorLog
    {
        public ContstrutorLog()
        {
            Debug.Log("기본생성자 호출");
        }
        public ContstrutorLog(string message)
        {
            Debug.Log($"오버로드 된 생성자 실행{message}");
        }
    }
}