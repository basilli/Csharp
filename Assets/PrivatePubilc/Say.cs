using UnityEngine;


/* [0] 개요 : Say
*/

namespace PrivatePublic
{

    public class Say
    {
        // [1] 정의 : 필드(Field, 멤버변수) 선언 및 초기화.
        string message = "こんにちは.";

        // [2] 가정 : 메서드(함수) 선언.
        public void Hi()
        {
            this.message = "久しぶりです";
            Debug.Log(this.message);
        }
    }
}
