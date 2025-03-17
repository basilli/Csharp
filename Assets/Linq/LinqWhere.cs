using UnityEngine;
using System.Collections.Generic;
using System.Linq;


/* [0] 개요 : LinqWhere
   		- using System.Collections.Generic;을 상부에 추가할 것.
		- using System.Linq;을 상부에 추가할 것.
		- LinqWhere(Where절, 조건절)
*/

public class LinqWhere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 정수형 배열 numbers의 요소수, 3보다 크고 짝수인 수 구한 후, 리스트에 넣기.
        int[] numbers = { 1, 2, 3, 4, 5 };
        // [2] 가정
        List<int> newNumber = numbers.Where(n => n > 3 && n % 2 == 0).ToList();
        /* [A]
        IEnumerable<int> newNumber = numbers.Where(n => n > 3 && n%2 ==0);
        */
        // [3] 결과
        foreach (var n in newNumber)
        {
            Debug.Log(n);
        }
    }
}
