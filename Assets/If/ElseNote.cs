using UnityEngine;

public class ElseNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (1 != 1)
        {
            // 실행문1
            Debug.Log("조건식이 참일 경우, 실행문1을 실행합니다.");
        }
        else
        {
            // 실행문2
            Debug.Log("조건식이 거짓일 경우, 실행문2을 실행합니다.");
        }
    }
}



/*
  [1] else문 정의
                    : 만약 조건식이 참일 경우, 실행문1을 실행합니다. 실행문2는 실행하지 않는다.
                    : 만약 조건식이 거짓일 경우, 실행문1을 실행하지 않습니다. 실행문2는 실행한다.

    if(조건식)
    {
     // 실행문1
    }
    else
    {
     // 실행문2
    }
     // 실행문 3

  [2] else문 가정
        - 조건식이 참일 경우, 실행문1 → 실행문3 순으로 진행된다.
        - 조건식이 거짓일 경우, 실행문2 → 실행문3 순으로 진행된다.


 */