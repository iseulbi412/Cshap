using UnityEngine;
namespace PrivatePublic
{
    public class PublicPravate
    {
        public static string name = "트럭";
        private int age;
        //정적 메서드
        //이름을 반환하는 함슈
        public static string GetName()
        {
            return name;
        }
        public void SetAge (int nai)
        {
            age = nai;
        }
        public int GetAge()
        {
            return age;
        }
    }
}