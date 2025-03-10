using UnityEngine;


/* [0] 개요 : BreakFor
        - 반복문(for, while...)에서 { }을 빠져나오는 명령문.
        - 반복문 안에서 break;문을 만날 경우, 즉시 반복문을 강제 종료함.

        - 안녕하세요를 5번 출력하느 프로그램을 만드시오. 단, i가 2일때 for문을 종료하시오.

        - 작업과정
                조건식(i=0) → 조건식(i<5) 참 → 출력
                조건식(i==2) 거짓 → 증감식(i=1) → 조건식(i<5) 참 → 출력
                조건식(i==2) 거짓 → 증감식(i=2) → 조건식(i<5) 참 → 출력
                조건식(i==2) 참 → break; → for문 종료
                break;의 위치에 따라서 종료되는 시점이 달라짐
          
 */
public class BreakFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("안녕하세요");

            if (i == 2)
            {
                break;
            }
        }
    }
}
