using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/* [0] 개요 : StackOfType
		- using System.Collections;을 상부에 추가할 것.
		- using System.Collections.Generic;을 상부에 추가할 것.
		- Generic Class : 형식 매개 변수 T에 지정한 형식, 클래스와 맴버의 성질이 결정되는 클래스.
		    - Cup<T> : Cup Of T, 
*/


public class StackOfType : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : Stack<T> 클래스의 인스턴스 생성. → <string>전용 stack 클래스의 인스턴스를 생성함.(문자열만 입력가능)
        Stack<string> stack = new Stack<string>();


        // [2] 가정 : 데이터 입력.(문자열만 입력 가능)
        stack.Push("10");
        stack.Push("TEN");

        // [3] 결과 : 데이터 출력.
        Debug.Log(stack.Pop());
        Debug.Log(stack.Pop());
    }
}
