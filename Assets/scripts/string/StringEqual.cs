using UnityEngine;

//문자열 비교하,기 - 2가지 방ㅂㅓㅂ
public class StringEqual : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string userName = "RedPlus";
        string inputName = "redPlus";

        //[1] 연산자{==)를 사용
        if (userName.ToLower() == inputName.ToLower())
        {
            Debug.Log("[1] 같습니다");
        }

        //[2] string.Equal()메서드 사용

        if (string.Equals(userName,inputName,System.StringComparison.InvariantCultureIgnoreCase))
        {

        }
    }
}
