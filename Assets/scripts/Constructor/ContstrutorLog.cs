using UnityEngine;
namespace Constructor
{
    public class ContstrutorLog
    {
        public ContstrutorLog()
        {
            Debug.Log("�⺻������ ȣ��");
        }
        public ContstrutorLog(string message)
        {
            Debug.Log($"�����ε� �� ������ ����{message}");
        }
    }
}