using UnityEngine;


// [0] 개요 : ElseIf
public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [1] 정의
               - score가 90점 이상일 경우 A.
               - score가 80점 이상일 경우 B.
               - score가 70점 이상일 경우 C.
               - score가 60점 이상일 경우 D.
               - 그 외의 경우 F.
         */
        int score = 99;
        char grade = 'A';

        // [2] 가정
        if (score >= 90)
        {
            grade = 'A';
        }
        else if (score >= 80)
        {
            grade = 'B';
        }
        else if (score >= 70)
        {
            grade = 'C';
        }
        else if (score >= 60)
        {
            grade = 'D';
        }
        else
        {
            grade = 'F';
        }

        // [3] 결과
        Debug.Log($"{grade} 학점");
    }
}
