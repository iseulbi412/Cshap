using Unity.VisualScripting;
using UnityEngine;

public class StructArray : MonoBehaviour
{
    struct UserInfo
    {
        public string name;
        public int age;

    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UserInfo info;
        info.name = "ȫ�浿";
        info.age = 20;
        PrintUserInfo(info.name, info.age);

        UserInfo[] userInfos = new UserInfo[2];
        userInfos[0].name = "��λ�";
        userInfos[0].age = 22;
        userInfos[1].name = "�Ӳ���";
        userInfos[2].age = 33;
        for(int i =0; i < userInfos.Length; i++)
        {
            PrintUserInfo(userInfos[i].name, userInfos[i].age);
        }

    }
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}���� ���̴�{age}�Դϴ�.");
    }
    void PrintUserInfo(UserInfo userInfo)
    {
        Debug.Log($"{userInfo.name}���� ���̴�{userInfo.age}�Դϴ�.");
    }
}
