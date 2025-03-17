using System.Collections.Generic;
using System.Linq;
using UnityEngine;


/* [0] 개요 : LinqSortList
		- using System.Collections;을 상부에 추가할 것. → Stack를 사용할 경우, 자동추가됨.
		- using System.Collections.Generic;을 상부에 추가할 것.
		- using System.Linq;을 상부에 추가할 것.
*/

public class LinqSortList : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 문자열 전용의 List 클래스 인스턴스 생성 및 초기화.
        List<string> colors = new List<string> { "Red", "Blue", "Green"};
        // [2] 가정 : 내림차순으로 실행.
        var sortedColors = colors.OrderByDescending(c => c);
        // [3] 결과

        foreach (var color in sortedColors)
        {
            Debug.Log(color);
        }
    }
}
