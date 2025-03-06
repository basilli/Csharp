using UnityEngine;

// [0] 개요 : IfElsePractice 연습문제
public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int score = 85;
        char a = '금';
        char b = '은';
        char c = '동';
        char d = '노';

        // [2] 가정 및 결과
        if (score >= 90)
        {
            Debug.Log($"{a}메달을 수상하였습니다.");
        }
        else
        {
            if (score >= 80)
            {
                Debug.Log($"{b}메달을 수상하였습니다.");
            }
            else
            {
                if (score >= 70)
                {
                    Debug.Log($"{c}메달을 수상하였습니다.");
                }
            }
            Debug.Log($"{d}메달을 수상하였습니다.");
        }
    }
}



/*
  [Q]
    - score : 85점
    - 90 이상일 경우, 금메달 출력.
    - 80 이상일 경우, 은메달 출력.
    - 70 이상일 경우, 동메달 출력.
    - 나머지는, 노메달 출력.
    [output]
    ( )메달을 수상하였습니다.
 */

/*
  [A]
{
        // [1] 정의
        int score = 85;

        // [2] 가정 및 결과
        if (score >= 90)
        {
            Debug.Log($"금메달을 수상하였습니다.");
        }
        else
        {
            if (score >= 80)
            {
                Debug.Log("은메달을 수상하였습니다.");
            }
            else
            {
                if (score >= 70)
                {
                    Debug.Log("동메달을 수상하였습니다.");
                }
            }
        }
    }
 */

/*
  [A]
    {
        // [1] 정의
        int score = 85;
        char a = '금';
        char b = '은';
        char c = '동';
        char d = '노';

        // [2] 가정 및 결과
        if (score >= 90)
        {
            Debug.Log($"{a}메달을 수상하였습니다.");
        }
        else
        {
            if (score >= 80)
            {
                Debug.Log($"{b}메달을 수상하였습니다.");
            }
            else
            {
                if (score >= 70)
                {
                    Debug.Log($"{c}메달을 수상하였습니다.");
                }
            }
            Debug.Log($"{d}메달을 수상하였습니다.");
        }
    }
}
 */