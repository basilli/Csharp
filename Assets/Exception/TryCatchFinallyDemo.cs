using UnityEngine;


/* [0] 개요 : TryCatchFinallyDemo
		- try절에서 예외가 발생할 경우 : [1] → [2] → [3]
		- try절에서 예외가 발생하지 않았을 경우 : [1] → [3]
*/

public class TryCatchFinallyDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int x = 5;
        int y = 0;
        int r = 0;

        // [2] 가정
        try		// ) 예외가 발생할 가능성이 있는 명령문.
        {
            // [2-1]
            r = x / y;
            Debug.Log($"{x} / {y} = {r}");
        }
        catch		// ) try절에서 예외가 발생할 경우, catch절을 실행함.
        {
            // [2-2]
            Debug.Log("예외가 발생하였습니다.");
        }
        finally		// ) try절에서 예외가 발생하거나 하지않아도 상관없이 실행함.
        {
            // [2-3]
            Debug.Log("프로그램을 종료합니다.");
        }
    }
}
