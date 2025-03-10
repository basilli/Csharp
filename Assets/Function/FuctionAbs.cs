using UnityEngine;


/* [0] 개요 : FuctionAbs
		- abs(절댓값)을 구하는 함수 만들기.
		- -5의 절댓값은 5, 143의 절댓값은 143
*/
public class FuctionAbs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 가정 : -21의 절댓값을 구하고 출력하기.
        int number = -21;
        int abs = Mathf.Abs(number);

        /* [A]
        int abs = Abs(number);
        */

        // [3] 결과
        Debug.Log($"{number}의 절댓값은 {abs} 이다.");

    }
    // [1] 정의 : 매개변수로 들어온 정수의 절댓값을 반환하는 함수.
    int Abs(int num)
    {
     return (num < 0) ? -num : num;

        /* {A]
        if (num < 0)
        {
        return -num;
        }
        else
        {
        return num;
        }
        */
    }
}
