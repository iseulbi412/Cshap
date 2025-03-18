using UnityEngine;
namespace Constructor
{
    public class ReadOnlyNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //WithService클래스의 객체 생성
            WithService flie = new WithService("[1]파일 로그");
            flie.Run();
            WithService db = new WithService("[2]DB서비스");
            db.Run();
        }
    }
}