using UnityEngine;
namespace Method
{
    public class Dog
    {
        public static int point = 10;
        public int weight = 20;

        public void Eat()
        {
            Debug.Log("[1]���� �Դ´�.");
            Digest();
        }
        public static void Drink()
        {
            Debug.Log("[2]���� ���Ŵ�.");
        }

        private void Digest()
        {
            Debug.Log("[3]��ȭ��Ų��.");
        }
    }
}