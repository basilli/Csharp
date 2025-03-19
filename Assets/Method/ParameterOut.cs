using UnityEngine;


/* [0] 개요 : ParameterOut
		- 반환형 전달 방법 : (out int num)
		- 정수형 out number를 매개변수로 입력받아 출력하는 함수
		- 반환형 매개 변수 전달방식을 가짐.
		- 참조형 방식과 동일함
        - 함수 내부에서 반드시 값을 설정해야함.
*/

namespace Method
{
    public class ParameterOut : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-2] 정의 : 정수형 변수 선언.(초기화 X)
            int number;
            // ) Debug.Log($"[1] : {number}"); → NG.

            PrintNumber(out number);

            // [2-3] 결과
            Debug.Log($"[2] : {number}");      // ) [2] 1234
        }
        // [1-1] 정의 : 반환형 전달 방법 : (out int num)
        void PrintNumber(out int number)
        {
            number = 1234;
            // [2-2] 결과
            Debug.Log($"[1] : {number}");       // ) [1] 1234

        }

    }
}
