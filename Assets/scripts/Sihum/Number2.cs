using UnityEngine;
namespace Munjea
{
    public class Number2
    {
        
    }

    public class Today
    {
        private string[] days = { "일", "월", "화", "수", "목", "금", "토" };


        public void PrintDays()
        {
            string dayList = string.Join(" ", days);
            Debug.Log(dayList);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}