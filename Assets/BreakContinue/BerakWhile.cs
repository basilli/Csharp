using UnityEngine;


/* [0] 개요 : BerakWhile
        - 1부터 10까지의 정수의 합을 구하는 프로그램을 만드시오.
        - 구한 합(sum)이 22(goal)이상일 경우, 더 이상 합을 구하지 않을 것.
        - while문을 이용해서 만들 것.
 */
public class BerakWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int n = 10;
        int sum = 0;
        int goal = 22;
        int i = 1;  // ) 초기식

        // [2] 가정
        while (i <= n)  // ) 조건식
        {
            sum = sum + i;  // ) 반복실행문
            if (sum >= goal) // ) 구한 합(sum)이 22(goal) 이상
            {
                break;
            }
            i++;    // ) 증감식
        }

        // [3] 결과
        Debug.Log($"1부터 {n}까지의 정수의 합 : {sum}");
    }
}
