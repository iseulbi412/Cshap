using UnityEngine;
namespace Inheritance07
{
    public class Animal
    {
        public void Eat() => Debug.Log("���� �Ծ��");
    }
    public sealed class Cat : Animal
    {

    }
   /* public class MyCAt : Cat
    {

    }*/
}