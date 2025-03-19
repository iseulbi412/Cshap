using System.Data;
using UnityEngine;
namespace Method
{
    public class ExpressionFunction : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Work();
            Hello();
            Debug.Log(DoubleValue(4));
            Debug.Log(Sum(3, 5));

        }
        void Work()
        {
            Debug.Log("Work");
        }
        void Hello() => Debug.Log("Hello");
        int DoubleValue(int value) => value * 2;
        int Sum(int a, int b) => a + b;
    }
}