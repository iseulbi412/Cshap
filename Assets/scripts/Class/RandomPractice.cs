using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

//로또 번호 생성기
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        System.Random rand = new System.Random();
        int[] numbers = new int[6];
        bool flag = false;
        int number = 0;
        for (int i = 0; i< 6; i++)
        {
            numbers[i] = rand.Next(1, 46);
            flag = false;
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;
                    }
                }
            }
            if(flag == false)
            {
                numbers[i] = number;
            }
            else
            {
                i--;
            }
        }
        for(int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }


    }
}

/*
[1]6개의 번호
[2]1~45번 사이의 랜덤 번호
[3]중복된 숫자가 나오면 안된다.



 */