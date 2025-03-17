using UnityEngine;


/* [0] 개요 : ToStringMethod
		- ToString( ) 를 다시 재정의하여 새로운 문자열을 출력.
*/

// [1-1] 정의 : My 클래스의 인스턴스 생성.
public class My
{ 
    // ) Empty
}

// [2-1] 정의 : Your 클래스의 인스턴스 생성.
public class Your
{
    public override string ToString()
    {
        return "새로운 반환 문자열 지정.";
    }
}

public class ToStringMethod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-2] 가정
        My my = new My();
        // [1-3] 결과
        Debug.Log(my);      // ) Empty 인스턴스를 출력하라고 할 경우, 클래스 이름이 출력됨.

        // [2-2] 가정
        Your your = new Your();
        // [2-3] 결과
        Debug.Log(your);      // ) Empty 인스턴스를 출력하라고 할 경우, 클래스 이름이 출력됨.
    }
}
