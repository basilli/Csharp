using UnityEngine;

// 만약 score가 60점 이상이면 "합격"이라고 출력할 것.
// 아니면 "불합격"이라고 출력.
// score 61점
public class Else : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int score = 59;

        if (score >= 60)    // [2] 조건식 01 : 만약 score가 60점 이상이면 "합격"이라고 출력할 것.
        {
            Debug.Log("합격");
        }
        else    // [3] 조건식 02 : 아니면 "불합격"이라고 출력.
        {
            Debug.Log("불합격");
        }

        Debug.Log("종료");   // [4] 종료.
    }
}


/*
    int score = 59; : [1] → [3] → [4]
    int score = 61; : [1] → [2] → [4]
 */