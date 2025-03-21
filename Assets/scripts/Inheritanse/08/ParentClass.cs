using UnityEngine;
namespace Inheritance08
{
    public abstract class ParentClass
    {
        public int Id { get; set; }
        public bool Active { get; set; }
    }
    public class ChildClass : ParentClass
    {
        public string Name { get; set; }
    }
}