using UnityEngine;

public class LogDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]
        Debug.Log("Hello Unity!!!");
        Debug.Log("����� : " + 5);
        Debug.Log("�Ӱ��� : " + (5 + 10));
        Debug.Log("����� : " + 5 + 5 + 10);
        // Update is called once per frame
    }
}
