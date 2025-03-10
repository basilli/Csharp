using UnityEngine;


/* [0] 개요 : ContinueDemo
        - 1부터 100까지의 정수 중에서 3의 배수를 제외한 합을 구하는 프로그램을 만들어라.
 
 */
public class ContinueDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int n = 100;
        int sum = 0;

        // [2] 가정
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)     // ) 3의 배수 판별식
            {
                continue;       // ) continue는 for문의 뒤에 있는 것이 일반적임. (맨 밑에 있을 경우, 효과가 X)
            }
            sum += i;
        }

        // [3] 결과
        Debug.Log($"1부터 {n}까지의 정수 중에서 3의 배수를 제외한 합은 {sum}이다.");
    }
}