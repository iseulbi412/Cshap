using UnityEngine;
namespace Constructor
{
    public class ReadOnlyNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //WithServiceŬ������ ��ü ����
            WithService flie = new WithService("[1]���� �α�");
            flie.Run();
            WithService db = new WithService("[2]DB����");
            db.Run();
        }
    }
}