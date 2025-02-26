//using 사용할 때
/*
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("HelloWorld!!!");
    }

}
using UnityEngine;

public class usingDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("HelloWorld!!!");
    }

}*/
//using 사용하지 않으면
// Start is called once before the first execution of Update after the MonoBehaviour is created



public class usingDemo : UnityEngine.MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UnityEngine.Debug.Log("HelloWorld!!!");
    }

}





