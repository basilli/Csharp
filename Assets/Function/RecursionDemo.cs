using UnityEngine;


/* [0] 개요 : RecursionDemo
		- 재귀함수 : 함수가 자신의 코드블록 안에서 자기 자신을 다시 호출하는 함수.
		- 재귀함수의 매개변수 : 매개변수는 가산, 감산이 됨.
        - 무한루프에 빠지지않을려면, 재귀함수 코드블록 안에는 재귀함수를 종료할 수 있는 조건이 필요함.
		- 함수가 자기 자신을 호출하는 프로그래밍 기법.
		- 반복문 없이도 반복적인 작업을 수행할 수 있도록 함.
		- 작은 문제로 나누어 해결하는 방식을 사용함. (ex. 팩토리얼, 피보나치 수열, DFS)
        - 구성
            - 기본 조건(Base Case) → 재귀를 멈추는 조건.
            - 재귀 호출(Recursive Case) → 자기 자신을 다시 호출.

        - 팩토리얼을 구하는 알고리즘(n(4!))을 만드시오.
*/

public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 4! = 1*2*3*4
        Debug.Log(4 * 3 * 2 * 1);

        // [2-2] 가정 : for문을 이용한 팩토리얼 구하기.
        Debug.Log(FactorialFor(4));

        // [2-3] 가정 : 재귀함수를 이용한 팩토리얼 구하기. (n! = n*(n-1)!)
        int Factorial(int n)
        {
            // [3] 결과 : 3항 연산자를 이용한 팩토리얼 만들기.
            int Factor(int n)
            {
                /*
                if (n <= 1)
                    return1;
                return n * Factor(n - 1);
                */
                return (n>1) ? n * Factor(n - 1) : 1;
            }

            // [3] 결과
            if (n == 1|| n==0)       // ) 종료조건 부분 → n을 음수로 할 경우, 무한으로 반복됨.
            {
                return 1;       // ) 재귀호출 부분 → 펙토리얼이 음수로 내려가서 무한히 반복되기에 불안정함.
            }
            return n * Factorial(n-1);
        }

        /*
            - 4*Factorial(3)
                Factorial(3) = 3*Factorial(2)
                    Factorial(2) = 2*Factorial(1) → 여기서 재귀호출 부분을 사용함
                        Factorial(1) = 1*Factorial(0)
                            Factorial(0) = 0*Factorial(-1)
                                Factorial(-1) = -1*Factorial(-2)
         */

        // [2-1] 가정 : for문을 이용한 팩토리얼 구하기.
        int FactorialFor (int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}
