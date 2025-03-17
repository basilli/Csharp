using System.Linq;
using System.Collections.Generic;
using UnityEngine;


/* [0] 개요 : LinqSort
		- using System.Collections;을 상부에 추가할 것. → Stack를 사용할 경우, 자동추가됨.
		- using System.Collections.Generic;을 상부에 추가할 것.
		- using System.Linq;을 상부에 추가할 것.
		- Sort : 정렬
*/

public class LinqSort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 문자열 배열을 오름차순으로 정렬할 것.
        string[] colors = { "Red", "Green", "Blue" };
        // [2-1] 가정 : 오름차순으로 실행.
        IEnumerable<string> sortedColors = colors.OrderBy(s => s);
        // [2-2] 가정 : 내림차순으로 실행.
        IEnumerable<string> sortedColors2 = colors.OrderByDescending(s => s);

        // [3-1] 결과
        foreach (var color in sortedColors)
        {
            Debug.Log(color);
        }
        // [3-2] 결과
        foreach (var color in sortedColors2)
        {
            Debug.Log(color);
        }
    }
}
