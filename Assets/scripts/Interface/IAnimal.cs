using UnityEngine;
namespace Interface
{
    public interface IAnimal
    {

    }
    
    public class Cat
    {

    }
    public class IDog
    {

    }
    public class Mycat : Cat, IAnimal
    {
        public void Eat() { }
    }
   
    public class Dog : IDog, IAnimal
    {
        public void Eat()
        {
            Debug.Log("¸Ô´Ù");
        }
        public void Cry()
        {
            Debug.Log("Â¢´Ù");
        }

    }
    
}