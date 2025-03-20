using UnityEngine;
namespace Delegate
{
    public class DelegateNote : MonoBehaviour
    {
        delegate void GoHome();
        GoHome go;

        delegate void Say();
        Say say3;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

            CarDriver.GoFoward();
            CarDriver.GoRight();
            CarDriver.GoFoward();
            CarDriver.GoLeft();
            Debug.Log("=============");
            go = new GoHome(CarDriver.GoFoward);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoFoward);
            go += new GoHome(CarDriver.GoLeft);
            go();
            Debug.Log("=============");
            Say say = new Say(Hello);
            say += new Say(Hi);
            say.Invoke();


            Insa insa = new Insa();
            Say say2 = insa.Bye;
            say2 += insa.Bye;
            say2 += Hi;
            say2.Invoke();
            Debug.Log("=============");

            

        }
        void Hello() => Debug.Log("Hello");
        void Hi()
        {
            Debug.Log("hi");
        }
    }
}