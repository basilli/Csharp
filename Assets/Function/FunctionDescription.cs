using UnityEngine;


/* [0] 개요 : FunctionDescription
		- Function(함수) = Method(메서드)
		- 반복해서 사용하도록 만들어진 하나 이상의 명령문으로 구성된 코드블럭.
        - 함수의 종류
		    - 내장함수 : 닷넷(C#)에서 제공하는 함수 or 유니티에서 제공하는 함수.
		    - 사용자함수 : 개발자가 만드는 함수.
        - 함수의 구성 : 입력 → 처리(연산) → 출력
        - 함수(메서드)의 서순
            [1] 함수 선언 (기능구현)
            [2] 함수 호출 (기능사용)\
        - 형태
            - 매개변수가 없는 함수
                void 함수이름 ( )
                {
                    // 하나 이상의 명령문
                    // ...
                }
            - 매개변수가 있는 함수
                void 함수이름 (매개변수)
                {
                    // 하나 이상의 명령문
                    // ...
                }
            - 반환값이 있는 함수
                (데이터타입) 함수이름 (매개변수?)        // ) 매개변수가 있을수도 없을수도 있음.
                {
                    // 하나 이상의 명령문
                    // ...
                }
                    retun 변수(값);        // ) 반환하는 변수와 값의 함수
*/
public class FunctionDescription : MonoBehaviour
{
    // [1] 정의 : Show 함수(메서드) 선언
    void Show()
    {
        Debug.Log("Hello World!!!");
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] Show 함수 호출
        Show();
    }
}
