using UnityEngine;


/* [0] 개요 : FunctionPractice
		- [Q]
            - 사칙연산을 구하는 함수를 만드시오.
            - 두개의 정수를 입력받아 +, -, *, /, %를 계산하여 결과값을 반환하는 함수를 만드시오.
            - Add, Subtract, Multiply, Devide, Remainder
            - 입력값 : 5, 3
		- [output]
*/

public class FunctionPractice : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-2] 결과 : Add
        int result;
        result = Add(5, 3);
        Debug.Log(result);

        // [2-2] 결과 : Subtract
        result = Substract(5, 3);
        Debug.Log(result);

        // [3-2] 결과 : Multiply
        result = Multiply(5, 3);
        Debug.Log(result);

        // [4-2] 결과 : Devide
        result = Devide(5, 3);
        Debug.Log(result);

        // [5-2] 결과 : Remainder
        result = Remainder(5, 3);
        Debug.Log(result);
    }
    // [1-1] 정의 : Add
    int Add(int x, int y) => x + y;

    // [2-1] 정의 : Subtract
    int Substract(int x, int y) => x - y;       // ) ' => '를 화살표 함수 or 람다식, 축약형 함수라고 부름.

    // [3-1] 정의 : Multiply
    int Multiply(int x, int y) => x * y;

    // [4-1] 정의 : Devide
    int Devide(int x, int y) => x / y;

    // [5-1] 정의 : Remainder
    int Remainder(int x, int y) => x % y;
}
