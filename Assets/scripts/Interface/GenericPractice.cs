using UnityEngine;
namespace GenericClass
{
    public class GenericPractice : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            GenericClas<int> numbers = new GenericClas<int>(3);
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            for (int i = 0; i<numbers.Length; i++)
            {
                Debug.Log(numbers[i]);
            }
        }
    }
}