using UnityEngine;


/* [0] 개요 : ForDescription
   for : 반복문
    - 초기식 : 조건식에서 사용하는 변수의 초기값 설정(초기화).
    - 조건식 : 조건식을 참, 거짓으로 판별하여, 참일 경우 반복실행문을 실행, 거짓일 경우 for문을 종료함.
    - 증감식 : 반복문을 실행할 때 마다, 실행한 직후 조건식에서 사용하는 변수의 값을 다시 연산해주는 식.

   for(초기식; 조건식; 증감식)
       {
       // 반복실행문
       }

    초기식 → 조건식 판별(참) → 반복실행문 실행 → 증감식 실행(바뀐 변수의 값을 다시 연산) → 조건식 판별(참) → 반복실행문 실행 → 증감식 실행 → 조건식 판별(거짓) → for문 종료
       : 초기식은 for문이 시작되었을 때만 실행됨.
 */
public class ForDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [1] 정의
            - 안녕하세요를 3번 출력하는 프로그램.
         */
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("안녕하세요.");
        }
        // 초기식(i값을 0으로 초기화) → 판별식(참) → 반복실행문(출력) → 증감식(i = 1) → 판별식(참) → 반복실행문(출력) → 증감식(i = 2) → 판별식(참) → 반복실행문(출력) → 증감식(i = 3) → 판별식(거짓) → for문 종료
    }
}
