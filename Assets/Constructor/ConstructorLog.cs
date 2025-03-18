using UnityEngine;


/* [0] 개요 : ConstructorOverload ConstructorLog
*/

namespace Constructor
{
    public class ConstructorLog
    {
        // [1] 정의 : 기본 Constructor 선언.
        public ConstructorLog()
        {
            Debug.Log("기본 생성자 호출");
        }

        // [1] 정의 : string 매개변수가 있는 Constructor 선언.
        public ConstructorLog(string message)
        {
            Debug.Log($"Overload된 Constructor 실행 : {message}");
        }
    }
}
