using UnityEngine;
namespace Interfacetase
{
    public class CarWorld : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Car campingCar = new Car("ķ��ī");
            campingCar.Run();

            Car sportCar = new Car();
            sportCar.Name = "������ī";
            sportCar.Run();
            Car cars = new Car(2);
            cars[0] = "1�� �ڵ���";
            cars[1] = "2�� �ڵ���";
            foreach(var c in cars)
            {
                Debug.Log(c);
            }
        }
    }
}