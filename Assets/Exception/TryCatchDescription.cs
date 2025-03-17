using UnityEngine;


/* [0] 개요 : TryCatchDescription
		- 예외처리(Exception Handling) : try-catch-finally문을 사용.
		- 예외(오류)
            - 문법의 오류 : 코딩을 하다가 생기는 오류.
            - 런타임의 오류 : 게임 실행중에 나오는 오류.
            - 알고리즘의 오류 : 플레이어의 지시사항에 올바르지않는 행동을 하는 오류.
		- 형태
            try
            {
                // 명령문
                // ...
            }
            catch
            {
                // try 코드블록 안에 있는 명령문을 실행 중 예외(Exception)가 발생할 경우, 즉시 처리할 내용
                // ...
            }
*/

public class TryCatchDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        try
        {
            int[] arr = new int[2];
            arr[100] = 10;
        }
        catch
        {
            Debug.Log("에러가 발생하였습니다.");
        }
    }
}
