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
        info.name = "홍길동";
        info.age = 20;
        PrintUserInfo(info.name, info.age);

        UserInfo[] userInfos = new UserInfo[2];
        userInfos[0].name = "백두산";
        userInfos[0].age = 22;
        userInfos[1].name = "임꺽정";
        userInfos[2].age = 33;
        for(int i =0; i < userInfos.Length; i++)
        {
            PrintUserInfo(userInfos[i].name, userInfos[i].age);
        }

    }
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}님의 나이는{age}입니다.");
    }
    void PrintUserInfo(UserInfo userInfo)
    {
        Debug.Log($"{userInfo.name}님의 나이는{userInfo.age}입니다.");
    }
}
