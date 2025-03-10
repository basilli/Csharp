using UnityEngine;


/* [0] 개요 : doWhile
        - for문이나 while문처럼 반복문에 속함.
        - 먼저, 반복실행문을 1번 실행함.
        - 조건식이 true일 경우, 반복문을 실행하고, false일 경우, 반복문을 종료함.
        - 형태
            do
            {
                // 반복실행문
            } while(조건식)
        - 작업과정
                조건식(i=0) 참 → 출력
                증감식(i=1) → 조건식(i<3) 참 → 출력
                증감식(i=2) → 조건식(i<3) 참 → 출력
                증감식(i=3) → 조건식(i<3) 거짓 → 종료

        - 안녕하세요를 3번 출력하는 프로그램을 만드시오.
 */
public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int i = 0;  // 1) 초기식

        // [2] 가정
        do
        {
            Debug.Log("안녕하세요");    // 2) 반복실행문
            i++;    // 3) 증감식
        } while (i < 3);    // 4) 조건식
    }
}