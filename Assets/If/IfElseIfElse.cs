using UnityEngine;


/* [0] 개요 : IfElseIfElse
    - 조건식 1)이 참일 경우.
        : 정의 → 실행문 1 → 실행문 4
    - 조건식 1)이 거짓이고, 조건식 2)가 참일 경우.
        : 정의 → 실행문 2 → 실행문 4
    - 조건식 1)이 거짓이고, 조건식 2)가 거짓일 경우.
        : 정의 → 실행문 3 → 실행문 4
    - 조건식 1)이 참이고, 조건식 2가 참일 경우.
        : ???
 */
public class IfElseIfElse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [1] 정의
              - number1, number2 값을 받는다.
              - 1) number1이 클 경우, "number1이 큽니다." 출력.
              - 2) number2가 클 경우, "number2가 큽니다." 출력.
              - 3) 나머지는 "두 수의 크기가 같습니다." 출력.
         */
        int number1 = 10;
        int number2 = 10;

        // [2] 가정
        // 조건식 1)
        if (number1 > number2)
        {
            // 실행문 1)
            Debug.Log("number 1이 큽니다.");
        }
        // 조건식 2)
        else if (number2 > number1) 
        {
            // 실행문 2)
            Debug.Log("number 2가 큽니다."); 
        }
        // 조건식 3)
        else
        {
            // 실행문 3)
            Debug.Log("두 수의 크기가 같습니다."); 
        }
    }
}
