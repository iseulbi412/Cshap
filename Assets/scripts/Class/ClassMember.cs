using UnityEngine;

public class ClassMember
{
    //[1]����(static) �޼���
    public static void StaticMethod()
    {
        Debug.Log("[1]����(static) �޼���");
    }
    //[2] �ν��Ͻ�(Instance) �޼���
    public void InstanceMethod()
    {
        Debug.Log("[2] �ν��Ͻ�(Instance) �޼���");
    }
}
