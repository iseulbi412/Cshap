using UnityEngine;
namespace Delegate
{
    public class DelegateDemo : MonoBehaviour
    {
        delegate double GetCircleArea(int r);
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            GetCircleArea area = GetArea;
            Debug.Log(area(10));
            Debug.Log(area.Invoke(10));

        }
        double GetArea(int r)
        {
            return 3.14 * r * r;
        }
    }
}