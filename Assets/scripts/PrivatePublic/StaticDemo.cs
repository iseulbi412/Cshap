using UnityEngine;
namespace PrivatePublic
{
    public class StaticDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //PublicPravate 클래스의 정적 필드, 정적 메서드 사용
            PublicPravate.name = "홍길동";
            //Debug.Log(PublicPravate.name);
            string sName =  PublicPravate.GetName();
            Debug.Log(sName);
            //PublicPravate.age = 22;(X)
            PublicPravate publicPravate = new PublicPravate();
            //publicPravate.age = 22;(X)
            publicPravate.SetAge(22);
            int myAge = publicPravate.GetAge();
            Debug.Log(myAge);
        }
    }
}