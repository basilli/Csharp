using UnityEngine;


/* [0] 개요 : WhileSum
        - while문을 이용하여 1부터 n(100)까지 합을 구하는 프로그램을 만드시오.
 */
public class WhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int n = 100;
        int sum = 0;    // 1) 결과를 저장하는 변수.
        int i = 1;  // 2) 초기식

        // [2] 가정
        while (i <= n)    // 3) 조건식
        {
            sum = sum + i;    // 4) 반복실행문
            i++;    // 5) 증감식
        }

        // [3] 결과
        Debug.Log($"1부터 {n}까지의 합 : {sum}");
    }
}
