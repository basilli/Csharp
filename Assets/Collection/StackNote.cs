using UnityEngine;
using System.Collections;


/* [0] 개요 : StackNote
*/

public class StackNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : Stack 클래스의 인스턴스(객체) 생성.
        Stack stack = new Stack();

        // [2] 가정 : 데이터 입력.
        stack.Push("대한민국");
        stack.Push("서울특별시");
        stack.Push("강동구");

        // [3-1] 결과 : Stack 제일 상단(마지막에 입력)에 위치한 데이터의 값을 반환.
        Debug.Log($"{stack.Peek()}, {stack.Count}");
        // [3-2] 결과 : 데이터 출력.
        stack.Pop();
        // [3-3] 결과 : Stack 제일 상단(마지막에 입력)에 위치한 데이터의 값을 반환.
        Debug.Log($"{stack.Peek()}, {stack.Count}");
        // [3-4] 결과 : 데이터 출력.
        if (stack.Count > 0)        // ) 데이터를 출력 할 때, 있는지 검토를 하기 위한 if.
        {
            stack.Pop();
        }
        // [3-5] 결과 : Stack 비우기.
        stack.Clear();
        Debug.Log($"{stack.Count}");
    }
}
