using UnityEngine;


/* [0] 개요 : SwitchNote
        - if(조건식)은 참과 거짓만을 판별할 수 있음.
            ex) if ( )
                {
                실행문 1
                }
                else
                {
                실행문 2
                }
        - switch(조건식)은 Data의 값을 판별함.
            ex) switch ( )
                {
                case 1번:
                실행문 1
                break;
                case 2번:
                실행문 2
                break;
                case 3번:
                실행문 3
                break;
                defalt : 모든 case가 아닐 경우, break;
                실행문 4
                break;
                }
        - int x = 2;
          (1) → (3) → (4)
        - int x = 1;
          (1) → (2) → (4)
 */
public class SwitchNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int x = 1; // (1)

        // [2] 가정
        switch (x)
        {
            case 1: // (2)
                Debug.Log("x는 1 입니다. ");
                break;
            case 2: // (3)
                Debug.Log("x는 2 입니다. ");
                break;
        }

        // [3] 결과
        Debug.Log("프로그램 종료. "); // (4)
    }
}
