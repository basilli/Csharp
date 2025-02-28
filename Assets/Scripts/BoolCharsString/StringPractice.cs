using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 변수
        string num = "3";
        // 상수
        const int message = "은(는) 홀수입니다."
        Debug.Log($"{num} - {message}");
    }

}



/*
    [Q] 
        3, 홀수를 변수 선언하고 저장한다.
        문자열 보간법을 이용해서 저장된 데이터 출력하기.

    [Output]
        3은(는) 홀수입니다.
*/
