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
            Debug.Log("��� ���� �߻� �޼��带 �����Ѵ�");
        }
    }

}