using UnityEngine;

public class ForCountdownDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 1; i < 5 + 1; i++)
        {
            Debug.Log($"���� ī��Ʈ�ٿ�:{i}");
        }
        Debug.Log("====================================");
        for(int i =5; i > 0; i--)
        {
            Debug.Log($"���� ī��Ʈ�ٿ�:{i}");
        }
    }

}
