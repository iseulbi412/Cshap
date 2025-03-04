using UnityEngine;
//ecrememtOprator(감소연산자):정수형 변수의 값을 1 감소
public class DecrememtOprator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int num = -100;
        --num;
        Debug.Log("num" + num);
    }

}
