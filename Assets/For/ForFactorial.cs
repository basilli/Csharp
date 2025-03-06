using UnityEngine;


/* [0] 개요 : ForFactorial(!)
        - 1부터 n까지의 자연수를 모두 곱하는 것.
        - 1! = 1
        - 2! = 1*2
        - 3! = 1*2*3
        - 4! = 1*2*3*4
        - n! = 1*2*3* ... (n-1)*n

        - 4! 값을 구하는 프로그램을 만드시오.
 */
public class ForFactorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int n = 10;
        int fact = 1;

        // [2] 가정
        for (int i = 1; i < n + 1; i++)

        {
            fact = fact * i;
        }

        // [3] 결과
        Debug.Log($"{n}!의 값은 {fact}이다.");
    }
}
