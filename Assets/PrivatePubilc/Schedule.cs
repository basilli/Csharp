using UnityEngine;


/* [0] 개요 : Schedule
        - 일요일~토요일까지 출력하는 함수 만들기. 
*/

// [1-1] 정의
namespace PrivatePublic
{ 


public class Schedule
   {
        // [1-1] 정의 : 배열 필드 선언(전역변수)
        string[] weekDays = { "Sun", "Mon", "Tue", "Wen", "Thu", " Fri", "Sat"};

        // [2] 가정 : 요일 출력하는 메서드.
        public void PrintWeekDays()
        {
            for (int i = 0; i < weekDays.Length; i++)
            {
                Debug.Log(weekDays[i]);
            }
        }
    }
}
