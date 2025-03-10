using UnityEngine;


/* [0] 개요 : ArrayIndex
        - Index : 인덱스
        - 몇번째 방, { } 안에 들어가는 변수 및 값.
        - 크기가 3인 정수형 배열을 선언하고 초기화 하시오.
 */

public class ArrayIndex : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 가정
        int[] numbers = { 1, 2, 3 };		// ) nubmers[0] → 1, nubmers[1] → 2, nubmers[2] → 3 
        int index = 0;      // ) 배열의 인덱스를 관리하는 변수, 항상 0으로 초기화 할 것. → 인덱스의 범위는 0~n-1(2)로 할 것.

        // [2] 결과
        Debug.Log(numbers[index++]);        // ) nubmers[0] → 1, index = 1
        Debug.Log(numbers[index++]);        // ) nubmers[1] → 2, index = 2
        Debug.Log(numbers[index++]);        // ) nubmers[2] → 3, index = 3

        Debug.Log(numbers[--index]);        // ) index = 2, nubmers[2] → 3
        Debug.Log(numbers[--index]);        // ) index = 1, nubmers[1] → 2
        Debug.Log(numbers[--index]);        // ) index = 0, nubmers[0] → 1
    }
}
