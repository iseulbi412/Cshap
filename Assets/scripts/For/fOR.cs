using UnityEngine;

public class fOR : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i;
        for (i = 1; i < 6; i++)
        {
            Debug.Log($"Count{i}");
        }
    }

}
