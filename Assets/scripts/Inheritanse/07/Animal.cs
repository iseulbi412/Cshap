using UnityEngine;
namespace Inheritance07
{
    public class Animal
    {
        public void Eat() => Debug.Log("¹äÀ» ¸Ô¾î¿ä");
    }
    public sealed class Cat : Animal
    {

    }
   /* public class MyCAt : Cat
    {

    }*/
}