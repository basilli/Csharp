using UnityEngine;


/* [0] 개요 : ParameterIn
		- 매개변수(Parameter) : 값이 전달되는 방법을 구분.
		    - 값 전달 방법 : (int num)
		    - 참조 전달 방법 : (ref int num)
		    - 반환형 전달 방법 : (out int num)
            - 가변형 전달 방법 : (params int[ ] numbers)
*/

namespace Method
{
    public class ParameterIn : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-2] 정의
            int num = 10;

            // [2-1] 결과
            Debug.Log($"[1] : {num}");      // ) [1] 10

            printNumber(num);

            // [2-3] 결과
            Debug.Log($"[3] : {num}");      // ) [3] 10

        }
        // [1-1] 정의 : 값 전달 방법 (int num) → 매개변수로 전달받은 정수(num)를 출력하는 함수.
        void printNumber(int num)
        {
            num = 20;
            // [2-2] 결과
            Debug.Log($"[2] : {num}");      // ) [2] 20
        }
    }
}
