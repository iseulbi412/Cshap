using UnityEngine;
namespace Constructor
{
    public class Car
    {
        private string color;
        public Car()
        {
            color = "하얀";
            Debug.Log($"{color}색 자동차를 만듭니다");
        }
        public Car (string _color)
        {
            this.color = _color;
            Debug.Log($"{color}색 자동차를 만듭니다");
        }
        public void Run()
        {
            Debug.Log($"{color}색 자동차를 달립니다");
        }
        ~Car()
        {
            Debug.Log($"{color}색 자동차를 폐차합니다");
        }
    }
}