using UnityEngine;
namespace Method
{
    struct Point
    {
        public int x;
        public int y;
    }
    public class ParameterIn2 : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Point point = new Point();
            point.x = 10;
            Debug.Log($"[1]point.x : {point.x}");
            PrintPoint(point);
            Debug.Log($"[3]point.x : {point.x}");

        }
        void PrintPoint(Point point)
        {
            point.x = 20;
            Debug.Log($"[2]point.x : {point.x}");
        }

    }
}