using UnityEngine;
namespace Inheritance08
{
    public class AbstractClassDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ParentClass parent = new ParentClass();
            ChildClass child = new ChildClass() { Id = 1, Active = true, Name = "ȫ�浿" };
            if(child.Active == true)
            {
                Debug.Log($"{child.Id} - {child.Name}");
            }
        }
    }
}