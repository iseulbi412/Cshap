using UnityEngine;
namespace Method
{
    public class ParametorOptional : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(Add(5));
            Debug.Log(Add(5,3));

        }
        int Add(int a, int b = 1)
        {
            return a + b;
        }
    }
}