using UnityEngine;
namespace Constructor
{
    public class ConstrutorForwarding : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Money basic = new Money();
            Money bonus = new Money(2000);
        }
    }
}