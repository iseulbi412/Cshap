using UnityEngine;

//String Ŭ����,StringBuilderŬ������ �̿��Ͽ� ���ڿ� �ٷ��
public class StringDescriotion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���ڿ� ���� �޼��� - �빮��, �ҹ���, �ٲٱ�
        string message = "hello World!";
        Debug.Log(message);

        //[1]�빮��
        Debug.Log(message.ToUpper());
        Debug.Log(message.ToLower());
        Debug.Log(message.Replace("hello","�ȳ��ϼ���").Replace("World","����"));
    }
}
