using UnityEngine;


/* [0] 개요 : GetSumTwoNumber
		- 두 수의 합을 구하는 함수 만들기.
*/
public class GetSumTwoNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [2] 가정
                - 두 정수(3,4)의 합을 반환값을 받아 출력.
         */
        int result = GetSum(3, 4);
        Debug.Log(result);
    }
    /* [1] 정의
            - 두 수의 합을 구하는 함수 만들기 : 매개변수, 반환값을 이용.
            - 매개변수로 들어온 두 정수의 합을 반환하는 함수 선언.
     */
    int GetSum(int x, int y)
    {
        return (x + y);
        /* [A]
            // int sum = x + y;
            // return sum;
         */
    }
}
