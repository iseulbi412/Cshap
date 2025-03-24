using UnityEngine;
namespace Override
{
    public class Animal
    {
        public virtual void Eat() => Debug.Log("Animal Eat");
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Debug.Log("강아지가 밥을 먹는다");
        }
    }
    public class Cat : Animal
    {
        public override void Eat()
        {
            base.Eat();

            Debug.Log("고양이가 밥을 먹는다");
        }
    }
}