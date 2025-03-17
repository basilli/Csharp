// [1] 정의
using System.Collections;
using UnityEngine;


/* [0] 개요 : StatckClass
		- Collections : Stack, Queue, ArrayList, HashTable가 있음.
        - Stack를 사용하려면 상부에 적힌 'using System.Collections;을 추가해야함.
*/

public class StatckClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : Stack 클래스의 인스턴스(객체) 생성.
        Stack st = new Stack();

        // [2] 가정 : 스택에 데이터를 넣기(Push)
        st.Push("First");
        st.Push("Second");

        // [3] 결과 : 스택에 데이터를 꺼내기(Pop)
        Debug.Log(st.Pop());
        Debug.Log(st.Pop());
    }
}
