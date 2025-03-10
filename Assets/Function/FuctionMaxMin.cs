using UnityEngine;


/* [0] 개요 : FuctionMaxMin
		- [Q]
            - 매개변수로 입력받은 두 개의 정수 중 큰 수를 반환하는 함수를 만드시오.
            - 매개변수를 입력받은 두 개의 정수 중 작은 수를 반환하는 함수를 만드시오.
            - 3, 5를 입력하여 큰 수를 출력하시오.
            - -3, -5를 입력하여 작은 수를 출력하시오.
        - [output]
            - 3과 5 중 큰 수는 (반환값) 입니다.
            - -3과 -5 중 작은 수는 (반환값)입니다.
*/
public class FuctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 3, 5를 입력하여 큰 수를 출력하시오.
        int max = GetMax(3, 5);
        Debug.Log($"3과 5 중 큰 수는 {max} 입니다.");

        // [4] -3, -5를 입력하여 작은 수를 출력하시오.
        /*
        int min = GetMin(-3, -5);
        Debug.Log($"3과 5 중 작은 수는 {min} 입니다.");
        */
    }
    // [1] 매개변수로 입력받은 두 개의 정수 중 큰 수를 반환하는 함수를 만드시오.
    int GetMax(int x, int y)
    {
        int maxValue;
        if (x > y)
        {
            maxValue = x;
        }
        else
        {
            maxValue = y;
        }
        return maxValue;

        /* [A] 3항 연산자
            int maxValue = (x > y) ? x : y;
            return maxValue;
         or
            return (x > y) ? x : y;
         or
            if (x > y)
            {
            return x;
            }
            else
            {
            return y;
            }
         */

        // [3] 매개변수를 입력받은 두 개의 정수 중 작은 수를 반환하는 함수를 만드시오.
        int GetMin(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }





    }
}
