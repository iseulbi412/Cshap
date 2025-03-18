using UnityEngine;
namespace Constructor
{
    public class ConstrutorOverlode : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ContstrutorLog 클래스 인스턴스 생성
            ContstrutorLog log1 = new ContstrutorLog();
            ContstrutorLog log2 = new ContstrutorLog("홍길동");
            ContstrutorLog log3 = new ContstrutorLog("백두산");
        }
    }
}