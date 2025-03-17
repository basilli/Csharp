using System.Collections;
using UnityEngine;
using System.Collections.Generic;


/* [0] 개요 : GenericDemo
		- using System.Collections;을 상부에 추가할 것. → Stack를 사용할 경우, 자동추가됨.
		- using System.Collections.Generic;을 상부에 추가할 것.
*/

public class GenericDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 정의 : Collection을 사용하는데, Generic를 사용하지 않을 경우.
        Stack st1 = new Stack();
        // [1-2] 가정
        st1.Push(1234);
        int number1 = (int)st1.Pop();       // ) 언박싱으로 인한 타입변환.
        // [1-3] 결과
        Debug.Log(number1);

        // [2-1] 정의 : Collection을 사용하는데, Generic를 사용할 경우.
        Stack<int> st2 = new Stack<int>();
        // [2-2] 가정
        st2.Push(5678);
        int number2 = st2.Pop();
        // [2-3] 결과
        Debug.Log(number2);

        // [3-1] 정의 : Generic의 장점 → 형식의 안정성, 성능상향
        Stack o = new Stack();
        // [3-2] 가정
        o.Push(1234);
        o.Push("Hello");
        // [3-3] 결과
        Debug.Log(o.Pop());
        Debug.Log(o.Pop());

        // [4-1] 정의
        Stack<int> i = new Stack<int>();
        // [4-2] 가정
        i.Push(2345); // )  → OK.
        // ) i.Push("TEN") → N.G, int만 가능함.
        // [4-3] 결과
        Debug.Log(i.Pop());

        // [5-1] 정의 : 성능 및 최적화하였을 경우.
        Stack stack = new Stack();
        // [5-2] 가정
        stack.Push(1234);       // ) 1234(값형)을 Object(참조형)으로 저장됨. → 박싱
        int iStack = (int)stack.Pop();      // )  Object(참조형)을 1234(값형)으로 저장됨. → 언박싱
        // [5-3] 결과
        Debug.Log(iStack);
    }
}
