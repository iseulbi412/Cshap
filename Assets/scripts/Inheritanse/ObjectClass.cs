using UnityEngine;
namespace Inheritance
{
    public class ObjectClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            ChildClass.Hi();
            ChildClass.Hello();
            ParentClass parent = new ParentClass();
            Debug.Log(parent.ToString());
            ChildClass child = new ChildClass();
            Debug.Log(child.ToString());
        }
    }
}