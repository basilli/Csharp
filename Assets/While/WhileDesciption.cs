using UnityEngine;

/* [0] 개요 : WhileDesciption (반복문)
        - 조건식이 true일 경우, 반복문을 실행하고, false일 경우, 반복문을 종료함.
        - 조건식(참) → 반복문 실행 → 조건식(참) → 반복문 실행 → 조건식(거짓) → while
        - 형태
            while(조건식)
            {
                // 반복실행문
                // 조건식에 들어가는 변수 증감식
            }
        - for을 활용한 안녕하세요를 3번 출력하는 프로그램 예시.
                for(초기식; 조건식; 증감식)
                for(int i = 0; i < 3; i++) → 반복횟수 : 3
                for(int i = 1; i <= 4; i++) → 반복횟수 : 4-1
                for(int i = 1; i <= 3; I++) → 반복횟수 : 3-1+1

        - 작업과정
                조건식(i=0) 참 → 출력
                증감식(i=1) → 조건식(i<3) 참 → 출력
                증감식(i=2) → 조건식(i<3) 참 → 출력
                증감식(i=3) → 조건식(i<3) 거짓 → 종료
 */

public class WhileDesciption : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int i = 0;  // 1) 초기식

        // [2] 가정
        while (i < 3)    // 2) 조건식
        {
            Debug.Log("안녕하세요");    // 3) 반복실행문
            i++;    // 4)증감식
        }
    }
}
