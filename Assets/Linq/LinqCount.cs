using UnityEngine;
using System.Linq;

/* [0] 개요 : LinqCount
        - 'using System.Linq;'을 상부에 추가할 것.
		- Linq : 확장 메서드.
*/

public class LinqCount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 정수형 배열의 요소수 갯수 얻어오기.
        int[] numbers = { 1, 2, 3 };
        // [2] 가정 : numbers.Length
        int count = numbers.Count();
        // [3] 결과
        Debug.Log($"numbers 배열의 갯수는 {count}");
    }
}
