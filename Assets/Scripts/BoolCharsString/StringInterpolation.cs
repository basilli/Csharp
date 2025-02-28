using UnityEngine;

// String Interpolation (문자열 보간법)
public class StringInterpolation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string message = "문자열 보간법";

        Debug.Log("Message : " + message); // [1] 문자열 + 연산
        Debug.Log($"Message : {message}"); // [2] 문자열 보간법
        Debug.Log("Message : {message}"); // [3] $를 빼면, message가 재대로 안나옴
        Debug.Log($"Message : message"); // [4] {}만 사라지고 message가 재대로 안나옴

        // String. Format
        string msg = string.Format("{0}님, {1}", "홍길동", "안녕하세요"); // [5] Format의 역할 : {0}자리에 "홍길동" ㅣ {1)자리에 "안녕하세요"

        Debug.Log(msg);
    }

}
