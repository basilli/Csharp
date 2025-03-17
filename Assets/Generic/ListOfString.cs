using System.Collections.Generic;
using System.Collections;
using UnityEngine;


/* [0] 개요 : ListOfString
		- using System.Collections;을 상부에 추가할 것. → Stack를 사용할 경우, 자동추가됨.
		- using System.Collections.Generic;을 상부에 추가할 것.
		- List Generic Class : List<T>를 List<int>, List<string>, ... List<Object>로 바꿈.
*/

public class ListOfString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : List<string> 전용 리스트의 인스턴스 생성.
        List<string> colors = new List<string>();

        // [2] List<string> 데이터 입력.
        colors.Add("Red");
        colors.Add("Green");
        colors.Add("Blue");

        // [3] List<string> 데이터 출력.
        foreach (var s in colors)
        {
            Debug.Log(s);
        }
    }
}
