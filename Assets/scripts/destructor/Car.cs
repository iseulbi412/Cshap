using UnityEngine;
namespace Constructor
{
    public class Car
    {
        private string color;
        public Car()
        {
            color = "�Ͼ�";
            Debug.Log($"{color}�� �ڵ����� ����ϴ�");
        }
        public Car (string _color)
        {
            this.color = _color;
            Debug.Log($"{color}�� �ڵ����� ����ϴ�");
        }
        public void Run()
        {
            Debug.Log($"{color}�� �ڵ����� �޸��ϴ�");
        }
        ~Car()
        {
            Debug.Log($"{color}�� �ڵ����� �����մϴ�");
        }
    }
}