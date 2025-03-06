using UnityEngine;


/* [0] 개요 : ForSumEven
        - 1부터 n(10)까지의 정수 중 짝수의 합을 구하는 프로그램을 만드시오.
        - 2+4+6...+8+10 = ???
 */
public class ForSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int n = 10;
        int sum = 0;

        // [2] 가정
        for (int i = 1; i < n + 1; i = i++)
        {
            sum = sum + i;
        }

        // [3] 결과
        Debug.Log($"1부터 10까지의 정수 중 짝수의 합은 {sum} 이다.");
    }
}


/*
            // [1] 정의
           int n = 10;
           int sum = 0;

            // [2] 가정
           for (int i = 1; i < n + 1; i = i++)
           {
                sum = sum + i;
           }

           // [3] 결과
           Debug.Log($"1부터 {n}까지의 합은 {sum} 이다.");
 */

/*

 */