using UnityEngine;


/* [0] 개요 : ParameterRef
        - 참조 전달 방법 : (ref int num)
*/


namespace Method
{
    public class ParameterRef : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-2] 정의
            int number = 10;

            // [2-1] 결과
            Debug.Log($"[1] : {number}");      // ) [1] 10

            PrintNumber(ref number);

            // [2-3] 결과
            Debug.Log($"[3] : {number}");      // ) [3] 20
        }
        // [1-1] 정의 : 참조 전달 방법 : (ref int num)
        void PrintNumber(ref int number)
        {
            number = 20;
            // [2-2] 결과
            Debug.Log($"[2] : {number}");       // ) [2] 20
        }
    }
}
