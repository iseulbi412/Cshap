using UnityEngine;
namespace Method
{
    public class PrameterRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number = 10;
            Debug.Log($"[1]: {number}");
            PrintNumber(ref number);
            Debug.Log($"[3]: {number}");
        }
        //������ ref number�� �Ű������� �Է� �޾� ����ϴ� �Լ�
        void PrintNumber(ref int number)
        {
            number = 20;
            Debug.Log($"[2]: {number}");
        }
    }
}