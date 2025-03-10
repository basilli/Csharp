using UnityEditor.PackageManager;
using UnityEngine;


/* [0] 개요 : DefaultParameter
		- 기본 매개변수 or 선택적 매개변수라고 함.
		- 매개변수를 선언할 때, 동시에 초기화도 함.
        - 선택적 매개변수는 함수 호출 시 생략이 가능하며, 생략시 초기한 값을 사용함.
*/
public class DefaultParameter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        // [2-1] 가정 : 매개변수가 없는 함수 호출.
        PrintMessage();
        // [2-2] 가정 : 매개변수가 있는 함수 호출.
        string error = "디버그";
        PrintError(error);
        // [2-3] 가정 : 반환값이 있는 함수 호출.
        string errorLog = PrintLog();
        Debug.Log(errorLog);
        */
        // [2-4] 가정 : 선택적 매개변수.
        PrintError("디버그", 4);
        PrintError("디버그");
    }
    // [1] 정의 :  Message를 3번 출력하는 함수를 만드시오.
    void PrintMessage()
    {
        string message = "디버그";
        Debug.Log(message);
;    }
    void PrintError(string message, int level = 1)
    {
        Debug.Log($"에러 : {message}, 레벨은 : {level}");
    }
    string PrintLog()
    {
        string log = "디버그 로그";
        return log;
    }
}
