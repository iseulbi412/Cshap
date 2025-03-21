using UnityEngine;
namespace Inheritance09
{
    public abstract class GenaralManager
    {
        public abstract void SayTalk();
        
    }
    public class Person : GenaralManager
    {
        public override void SayTalk()
        {
            Debug.Log("상속 받은 추상 메서드를 구현한다");
        }
    }

}