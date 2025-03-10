using UnityEngine;

// 순차문 : 위에서 아래로 순서대로 명령문을 실행.
public class SequenceDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 변수선언 - 초기화
        int kor = 100;                // 국어점수
        int eng = 90;                 // 영어점수
        int total = 0;                  // 총점
        double avg = 0.0;           // 평균

        // [2] 변수에 값 대입
        total = kor + eng;          // 총점
        avg = total / 2.0;            // 평균

        // [3] 변수 사용
        Debug.Log($"총점 : {total}");
        Debug.Log($"평균 : {avg}");

    }
}


/*
    [1] 제어문 : 프로그램의 흐름(순서)를 정하는 구문.
        - 순차문 : 위에서 아래로 순서대로 명령문을 실행. → 아무것도 하지않아도 알아서 실행됨.
        - 조건문 (if-else, switch) : 조건에 따른 서로 다른 명령문을 실행.
        - 반복문 (for, while...) : 
        - break문 : 반복문(for, while)에서 { }을 빠져나오는 명령문.
        - continue문 : 
 */