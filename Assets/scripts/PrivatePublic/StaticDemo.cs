using UnityEngine;
namespace PrivatePublic
{
    public class StaticDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //PublicPravate Ŭ������ ���� �ʵ�, ���� �޼��� ���
            PublicPravate.name = "ȫ�浿";
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