using UnityEngine;

namespace PrivatePublic
{
    //필드의 종류
    public class Person
    {
        //[1]변수 형식의 필드
        private string name = "홍길동";
        //[2]상수 형식의 필드
        private const int Age = 21;
        private readonly string Nickname = "도깨비";
        private string[] address = { "서울", "수원", " 인천" };
        private object obj = System.DateTime.Now.ToShortTimeString();

        public void ShowProfile()
        {
            Debug.Log($"이름: {name}, 나이:{Age}, 별명{Nickname}");
        }
    }
}
