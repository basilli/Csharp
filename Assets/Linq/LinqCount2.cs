using UnityEngine;
using System.Linq;


/* [0] 개요 : LinqCount2
		- using System.Collections;을 상부에 추가할 것. → Stack를 사용할 경우, 자동추가됨.
		- using System.Linq;을 상부에 추가할 것.
*/

public class LinqCount2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : bool형 배열변수에서 true값의 갯수, false값의 갯수 구하기.
        bool[] blns = { true, false, true, false, true };
        // [2] 가정 : 전체 요소수 구하기.
        Debug.Log(blns.Count());
        // [3-1] 결과 : true값의 갯수.
        Debug.Log(blns.Count(b=>b==true));
        // [3-2] 결과 : false값의 갯수.
        Debug.Log(blns.Count(a => a == false));
    }
}
