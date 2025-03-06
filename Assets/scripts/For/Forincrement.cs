using UnityEngine;

public class Forincrement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i;
        for (i = 0; i < 11; i=i+2)
        {
            Debug.Log(i);
        }
    }

}
