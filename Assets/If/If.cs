using UnityEngine;

// 만약 score가 60점 이상이면 "합격"이라고 출력할 것.
// score 61점
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int score = 61;

        if (score >= 60);   // 조건문이 참이면 블록 안에 있는 실행문을 실행.
        {
            // [2] 실행문
            Debug.Log("합격");
        }
    }
}


/*
    [1] 제어문 : 프로그램의 흐름(순서)를 정하는 구문.
        - 조건문(if-else, switch) : 조건에 따른 서로 다른 명령문을 실행.
            - if문
                : 조건식이 참일때만 실행문이 실행됨.
                : 조건식이 거짓이면 실행문을 실행하지않음.

                // 만약 조건식이 참이면 {} 안에 있는 실행문을 실행하라.
                    if(조건식)
                    {
                     // 실행문1
                     // 실행문2
                     // ...
                    }

                    if(bool)
                    {
                     // 실행문1
                     // 실행문2
                     // ...
                    }
 */