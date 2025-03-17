using UnityEngine;
using System.Collections.Generic;
using System.Linq;

/* [0] 개요 : LinqSum
		- using System.Collections;을 상부에 추가할 것. → Stack를 사용할 경우, 자동추가됨.
		- using System.Collections.Generic;을 상부에 추가할 것.
		- using System.Linq;을 상부에 추가할 것.
*/


public class LinqSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 문자열 배열의 합.
        int[] numbers = { 1, 2, 3 };
        int sum = 0;

        // [2] 가정
        sum = numbers.Sum();
        // [3] 결과
        Debug.Log($"numbers 요소들의 합 : {sum}");
    }
}
