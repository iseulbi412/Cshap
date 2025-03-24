using UnityEngine;
namespace Interfacetase
{
    public class CarWorld : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Car campingCar = new Car("캠핑카");
            campingCar.Run();

            Car sportCar = new Car();
            sportCar.Name = "스포츠카";
            sportCar.Run();
            Car cars = new Car(2);
            cars[0] = "1번 자동차";
            cars[1] = "2번 자동차";
            foreach(var c in cars)
            {
                Debug.Log(c);
            }
        }
    }
}