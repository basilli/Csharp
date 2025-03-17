using UnityEngine;


/* [0] 개요 : NullNote
		- Null 연산자
            - ?? : Null 병합 연산자
            - ?. : Null 조건부 연산자
*/


public class NullNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 정의 : ??(Null 병합 연산자)
        string nullValue = null;
        string message = "";
        // [1-2] 가정 : message 변수 초기화.
        message = nullValue ?? "null일 경우, 새로운 값으로 초기화.";
        /* [A]
        if (nullValue == null)
        {
            message = "null일 경우, 새로운 값으로 초기화.";
        }
        */
        // [1-3] 결과
        Debug.Log(message);

        // [2-1] 정의 : ?. (Null 조건부 연산자)
        int? len;       // ) len : message 길이를 저장하는 변수.
        string msg = null;
        // [2-2] 가정
        len = msg?.Length;       // ) msg가 null이면, null을 반환함. null이 아니면 ?. 뒤에 있는 값을 반환함.
        msg = "안녕하세요.";
        len = msg?.Length;
        /* [A]
        if (msg != null)
        {
            len = msg.Length;
        }
        else
        {
            len = null;
        }
        */
        // [2-3] 결과
        Debug.Log(len);
    }
}
