using Unity.VisualScripting;
using UnityEngine;


/* [0] 개요 : ForSumPractice
        [Q]
            - 1부터 100까지의 정수 중, 3의 배수 또는 4의 배수를 구해서 합하는 프로그램을 만드시오.
        [output]
            - 합은 { }
 */
public class ForSumPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int n = 100;
        int sum = 0;

        // [2] 가정
        for (int i = 1; i < n + 1; i++)
        {
             // [2-1] 3의 배수 또는 4의 배수 → 중복되는 값을 제외하고 계산함.
             if (i%3 == 0 || i%4 == 0)
             {
                 sum = sum + i;
             }

            /*
            // [2-2] 3의 배수 또는 4의 배수 → 중복되는 값을 포함해서 계산함.
            if (i % 3 == 0)
            {
                sum = sum + i;
            }
            if (i % 4 == 0)
            {
                sum = sum + i;
            }
            */
        }

        // [3] 결과
        Debug.Log($"1부터 100까지의 정수 중, 3의 배수 또는 4의 배수의 합은 {sum}이다. ");
    }
}


