using UnityEngine;


/* [0] 개요 : MethodOverloadDemo
		- 인사하는 함수(Hi)를 구현 하시오.
*/

public class MethodOverloadDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 가정
        Hi();
        Hi("반갑습니다.");
        Hi("감사합니다.", 3);
    }
    // [1-1] 정의 : 매개변수가 없는 함수.
    void Hi()
    {
        Debug.Log("안녕하세요.");
    }
    // [1-2] 정의 : 매개변수(string message)가 있는 함수.
    void Hi(string message)
    {
        Debug.Log(message);
    }
    // [1-3] 정의 : 매개변수로 입력 (message)를 매개변수로 받은 (count) 횟수만큼 있는 함수.
    void Hi(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Debug.Log(message);
        }
    }
}
