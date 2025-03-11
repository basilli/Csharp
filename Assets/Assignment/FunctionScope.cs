using UnityEngine;


/* [0] 개요 : FunctionScope
		- 전역변수, 지역변수
*/

public class FunctionScope : MonoBehaviour
{
    // [1] 정의 : 전역변수
    string message = "전역변수";        // ) 필드, 맴버 변수라고도 부름. → 어떤 함수에도 속하지 않는 변수.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [3] 결과
        ShowMessage();
        PrintMessage();
        Debug.Log(message);

        // [2-1] 가정 : msg를 출력하는 함수
        void ShowMessage()
        {
            string message = "지역변수";        // ) 이름이 같을 경우, 지역변수를 먼저 따라감. → 해당 코드블럭 안에서만 사용할 수 있음.
            Debug.Log(message);
        }
    }
    // [2-2] 가정
    void PrintMessage()
    {
        Debug.Log(message);     // ) 위에 있는 string msg는 위에 있는 코드블럭 안에서만 성립하기때문에 NG가 남. → 전역변수를 알아봄
    }
}
