using UnityEngine;


/* [0] 개요 : FunctionCall
*/
public class FunctionCall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 함수 호출 및 사용 : 3번 호출
        Hi();
        Hi();
        Hi();
    }

    // [1] 정의 : 함수 만들기(=선언)
    void Hi()
    {
        Debug.Log("안녕하세요.");
    }
}
