using UnityEngine;
namespace Inheritance11
{
    public class FildHiddenDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            SubClass sub = new SubClass();
            sub.SetWord("�ʵ� ����� �� �ڽ� Ŭ�������Ը� ��� ���");
            Debug.Log(sub.GetWord());
        }
    }
}