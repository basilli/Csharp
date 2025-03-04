using UnityEngine;

// + : 더하기 연산의 추가 기능
public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 문자열 더하기
        Debug.Log("Hello" + "World!!!");
        Debug.Log("Hi" + " " + "Everyone!");

        Debug.Log("123" + "456");                   // 문자열 + 문자열 = 문자열.
        Debug.Log("123" + 456);                     // 문자열 + 숫자 = 문자열.
        Debug.Log(123 + "456" + 789 + 890);     // 숫자 + 문자열 + 숫자 + 숫자 = 문자열.
        Debug.Log(123 + 456);                       // 숫자 + 숫자 = 숫자.
        Debug.Log("123" + true);                    // 문자열 + bool형 = 문자열.

        // [2] 문자열 빼기
        Debug.Log("123" - "456");                   // 문자열에서 정수형 데이터를 뺄 수 없음.
    }
}
