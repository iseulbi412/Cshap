using UnityEngine;
namespace Indexer
{
    public class IndexerDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Catalog ca = new Catalog();
            Debug.Log(ca[0]);
            Debug.Log(ca[1]);
            Debug.Log(ca[2]);
            Debug.Log(ca[99]);
        }
    }
}
/*
 Indexer(�ε���) : Ŭ������ �ν��Ͻ�(��ü)�� �迭ó�� []�� ����� �� �ֵ��� ���ִ� ����
�ν��Ͻ� �̸�[0] �ν��Ͻ��̸�[1]
Ŭ������ �ʵ�(�迭, �÷���)�� ���� �ε����� ȣ���ؼ� ���(�б�, ����)

�ε��� ����
Class Car
Car cars = new Car(3);
cars[0] = "a"
cars[1] = "b"
cars[2] = "c"
 */