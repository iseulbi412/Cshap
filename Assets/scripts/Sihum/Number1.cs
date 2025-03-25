using UnityEngine;
using static Munjea.Number2;
namespace Munjea
{
    public class Number1 : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            void Start()
            {
                Today today = new Today();
                today.PrintDays();
                //Today aInstance = gameObject.AddComponent<Today>();
               
                Debug.Log("5 + 6 = " + Today.Add(5,6));
            }
    }
}