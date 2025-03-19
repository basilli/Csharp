using UnityEngine;


/* [0] 개요 : ParameterOptional
		- OptionalParameter(선택적 매개변수) : 사용해도 되고, 생략해도 됨.
*/


namespace Method
{
    public class ParameterOptional : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [2] 결과
            Debug.Log(Add(5));      // ) 5+1
            Debug.Log(Add(5,3));        // ) 5+3
        }
        // [1] 정의 : b를 선택적 매개변수로 설정하여, 선언과 동시에 초기값 설정. → b변수는 사용해도 되고, 생략할 경우 b=1 이다.
        int Add(int a, int b = 1)
        {
            return a + b;
        }
    }
}
