using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

//�ζ� ��ȣ ������
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
[1]6���� ��ȣ
[2]1~45�� ������ ���� ��ȣ
[3]�ߺ��� ���ڰ� ������ �ȵȴ�.



 */