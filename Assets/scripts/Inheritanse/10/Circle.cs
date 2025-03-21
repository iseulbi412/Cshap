using UnityEngine;
namespace Inheritance10
{
    public class Circle : Shape
    {
        private int size;
        public Circle(int _size)
        {
            this.size = _size;
        }
        public override double GetArea()
        {
            return size * size * 3.14;
        }
    }
}