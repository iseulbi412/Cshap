using UnityEngine;
namespace Constructor
{
    public class ConstrutorOverlode : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ContstrutorLog Ŭ���� �ν��Ͻ� ����
            ContstrutorLog log1 = new ContstrutorLog();
            ContstrutorLog log2 = new ContstrutorLog("ȫ�浿");
            ContstrutorLog log3 = new ContstrutorLog("��λ�");
        }
    }
}