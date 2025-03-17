using UnityEngine;

/* [0] 개요 : NullDescription
		- Null
            - 아무것도 없는 상태, 아무것도 없음을 의미하는 리터널.
		    - 인스턴스가 아무것도 참조하지않음 → null 참조. 
            - 예시
                (값형식) x = 1234
                (참조형식) s = -> "안녕하세요"
                (참조형식) o = ->                    → 참조형식으로 가르켰지만, 아무것도 없는 상태, o에 아무런 값도 설정하지않음 = null 참조.
                string의 " "(빈값,empty)은 null과 다름.
*/


public class NullDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 정의 : 값형식. → null을 넣을 수 없음.
        int i = 0;
        // [1-2] 정의 : 참조형식. → null을 넣을 수 있음.
        string s = null;
        s = "안녕하세요.";
        // [1-3] 정의 : 참조형식.
        string empty = "";
    }
}
