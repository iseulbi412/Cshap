using UnityEngine;
namespace Method
{
    public class Dog
    {
        public static int point = 10;
        public int weight = 20;

        public void Eat()
        {
            Debug.Log("[1]밥을 먹는다.");
            Digest();
        }
        public static void Drink()
        {
            Debug.Log("[2]물을 마신다.");
        }

        private void Digest()
        {
            Debug.Log("[3]소화시킨다.");
        }
    }
}