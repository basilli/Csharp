using System.Collections;
using UnityEngine;


/* [0] 개요 : StackDemo
		- Stack를 사용하려면 상부에 적힌 'using System.Collections;을 추가해야함.
		- Stack 클래스 : LIFO(Last In First Out) 형태로 데이터를 저장하는 관리 클래스.
            - LIFO : 후입선출, 가장 마지막에 넣은 데이터를 가장 먼저 꺼낸다.
            - 주방의 접시를 쌓아놓았을 때와 비슷한 데이터 구조.
		- Push ( ) : 스택 구조에 데이터를 입력.
		- Pop ( ) : 스택 구조에 데이터를 출력.
        - Peek ( ) : 스택 구조에서 데이터중 가장 상단(마지막에 입력)에 위치한 데이터의 값을 반환.
        - Count : 스택 구조에 현재 저장되어있는 데이터의 수. → Array가 .Length로 가져오듯이 Stack 또한 Count로 정보를 가져옴.
        - Clear ( ) : 스택 구조에서 데이터 모두 비우기.
		- Overflow : 스택 구조에 데이터가 가득 찼을 때 발생.
        - Underflow : 스택 구조에 데이터가 텅 비었을 때 발생.
*/

public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : Stack 클래스의 객체(인스턴스, 개체) 생성.
        Stack stack = new Stack();

        // [2] 가정 : 데이터 입력.
        stack.Push("첫번째");
        stack.Push("두번째");
        stack.Push("세번째");

        // [3-1] 결과 : 데이터 출력.
        Debug.Log(stack.Pop());     // ) 세번째
        Debug.Log(stack.Pop());     // ) 두번째
        Debug.Log(stack.Pop());     // ) 첫번째
        // [3-2] 결과 : 비어있는 Stack에서 Pop을 이용하여 데이터를 출력. → Underflow
        try
        {
            Debug.Log(stack.Pop());
        }
        catch (System.Exception ex)
        {
            Debug.Log($"에러내용 : {ex.Message}");
        }
    }
}
