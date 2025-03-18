using UnityEngine;
namespace Constructor
{
    public class My
    {
        private string name;
        int age;
        public My(string _name, int _age)
        {
            this.name = _name;
            this.age = _age;
        }
        public void PrintMyInfo()
        {
            Debug.Log($"이름{this.name},나이{this.age}");
        }
    }
}