using UnityEngine;


/* [0] 개요 : StringDescription
		- String Class, StringBuilder Class를 이용하여 문자열 다루기.
*/

public class StringDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 정의 : 문자열 관련 메서드
        string message = "hello WORLD!!!";
        // [1-2] 결과
        Debug.Log(message);
        // [1-3] 결과 : 대·소문자로 바꾸기.
        Debug.Log(message.ToUpper());
        Debug.Log(message.ToLower());
        // [1-4] 결과 : 바꿔치기.
        Debug.Log(message.Replace("hello", "안녕하세요").Replace("WORLD","세계"));
    }
}
