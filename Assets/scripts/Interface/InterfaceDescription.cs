using UnityEngine;
namespace Interface
{
    public class InterfaceDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //ICar icar = new ICar();
            Car car = new Car();
            car.Go();
        }
    }
}
/*
Interface(�������̽�) : ���  ���� �ڽ� Ŭ������ Ư�� ����� �ݵ�� �����Ǿ�� ���� ����
��ӹ��� �ڽ�Ŭ������ Ư�� ����� �����ϵ��� �����Ѵ�
�������̽��� �̸� �۸�� �� �տ��ִ� ���ڴ� �빮�� I�� ���δ�
 */