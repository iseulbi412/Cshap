using UnityEngine;
namespace Constructor
{
    public class ConstrutorParametor : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            My my = new My("ȫ�浿", 21);
            my.PrintMyInfo();
        }
    }
}