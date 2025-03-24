using UnityEngine;
namespace Interface
{
    public interface IBattery
    {
        string GetName();
    }
    public class Good : IBattery
    {
        public string GetName()
        {
            return "Good";
        }
    }
    public class Bad : IBattery
    {
        public string GetName()
        {
            return "Bad";
        }
    }
    public class HdCar
    {
        private IBattery battery;
        public HdCar(IBattery _battery)
        {
            this.battery = _battery;
        }
        public void Run()
        {
            Debug.Log($"{battery.GetName()}배터리를 장착한 차가 달린다");
        }
    }
}