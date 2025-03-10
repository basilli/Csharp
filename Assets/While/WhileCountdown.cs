using UnityEngine;

/* [0] 개요
        - 1,2,3,4,5(오름차순) & 5,4,3,2,1(내림차순)
 */

public class WhileCountdown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 1~5까지 1씩 증가(오름차순)
        int i = 1;  // 1) 초기식

        // [2] 가정
        while (i <= 5)  // 2) 조건식
        {
            Debug.Log($"카운트다운 : {i}");  // 3) 반복실행문
            i++;    // 4) 증감식
        }

        Debug.Log(" ========================================================================================================================================== ");

        // [1] 정의 : 1~5까지 1씩 감소(내림차순)
        int j = 5;  // 1) 초기식

        // [2] 가정
        while (j >= 1)  // 2) 조건식
        {
            Debug.Log($"카운트다운 : {j}");  // 3) 반복실행문
            j--;    // 4) 증감식
        }


    }



}
