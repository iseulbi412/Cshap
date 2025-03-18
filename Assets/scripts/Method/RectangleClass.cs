using UnityEngine;
namespace Method
{
    public class RectangleClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Rectangle rect = new Rectangle();
            Debug.Log(rect.GetName());
        }
    }
}