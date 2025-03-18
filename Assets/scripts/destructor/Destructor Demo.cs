using UnityEngine;
namespace Constructor
{
    public class DestructorDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Car whiteCar = new Car();
            whiteCar.Run();

            Car blueCar = new Car("ÆÄ¶õ");
            blueCar.Run();

            Car redCar = new Car("»¡°£");
            redCar.Run();
        }

    }
}