using UnityEngine;


/* [0] 개요 : FunctionParameter
		- Parameter : 매개변수
*/
public class FunctionParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 매개변수가 있는 함수 사용.
        showmessage("안녕하세요.");
        showmessage("안녕");
    }

    /* [1] 정의
        - 매개변수가 있는 함수 선언.
        - 매개변수를 통해 들어온 문자열을 출력.
     */
    void showmessage(string message)
    {
        Debug.Log(message);
    }
}
