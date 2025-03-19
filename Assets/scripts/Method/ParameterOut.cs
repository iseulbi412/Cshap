using UnityEngine;
namespace Method
{
    public class ParameterOut : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number;
            PrintNumber(out number);
            Debug.Log($"[3]: {number}");
        }
        void PrintNumber(out int number)
        {
            number = 1234;
            Debug.Log($"[2]: {number}");
        }
    }
}