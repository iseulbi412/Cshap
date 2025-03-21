using Inheritance;
using UnityEngine;
namespace Override
{
    public class MethodOverrideDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Child child = new Child();
            child.Say();
            child.Run();
            child.Walk();
        }
    }
}