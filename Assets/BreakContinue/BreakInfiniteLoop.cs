using UnityEngine;


/* [0] 개요 : BreakInfiniteLoop
        - break로 무한루프를 빠져나올 수 있음.
        - nubmer가 5 이상일 경우, while문을 종료 할것.
        - 
 */
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int number = 0;

        // [2] 가정
        while (true)    // 1) 무한루프.
        {
            Debug.Log(number);  // 2)반복실행문

            number++;
            if (number >= 5)
            { 
                break;
            }
        }
    }
}
