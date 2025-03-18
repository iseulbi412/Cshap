using UnityEngine;
namespace PrivatePublic
{
    public class Field : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Person person = new Person();
            person.ShowProfile();
        }

    }
}