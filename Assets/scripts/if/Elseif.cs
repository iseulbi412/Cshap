using UnityEngine;

public class Elseif : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 99;
        char grade = 'A';
        if (score >= 90)
        {
            grade = 'A';
        } else if(score >= 80)
        {
            grade = 'B';
        }
        else if (score >= 70)
        {
            grade = 'C';
        }
        else if (score >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }
        Debug.Log("점수는" + grade + "입니다");
    }

}
