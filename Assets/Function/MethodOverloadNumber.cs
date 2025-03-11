using UnityEngine;


/* [0] 개요 : MethodOverloadNumber
		- MethodOverload(메서드 오버로드) : 함수 다중정의
		- 동일한 이름의 메서드의 매개변수를 달리해서 여러개를 생성하는 것. → 이름은 같은데 타입을 다르게해서 불러낼 수 있음.
		- 클래스나 인터페이스 내에서 같은 이름의 메서드를 여러 개 정의하는 기능으로, 매개변수의 수를 변경하여 구현할 수 있음.
        - 같은 이름의 메서드를 여러 개 정의할 수 있음.
        - 매개변수의 수, 타입, 순서를 변경하여 구현할 수 있음.
        - 같은 작업을 다양한 방법으로 수행할 수 있음.
*/

public class MethodOverloadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 매개변수로 숫자를 입력받아 출력하는 함수(PrintNumber)
        PrintNumber(1234);
        PrintNumber(1234L);
        PrintNumber(1234F);
    }
    // [2-1] 가정 : int 타입의 정수를 매개변수로 입력받아 출력. (매개변수로 숫자를 입력받아 출력하는 함수, PrintNumber)
    void PrintNumber(int number)
    {
        Debug.Log($"Int32 : {number}");
    }

    // [2-2] 가정 : long 타입의 정수를 매개변수로 입력받아 출력.
    void PrintNumber(long number)
    {
        Debug.Log($"Int64 : {number}");
    }

    // [2-3]  가정 : Float 타입의 실수를 매개변수로 입력받아 출력.
    void PrintNumber(float number)
    {
        Debug.Log($"실수형 : {number}");
    }
}
