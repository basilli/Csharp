using PrivatePublic;
using UnityEngine;


/* [0] 개요 : VariableScope
*/

namespace PrivatePublic
{
    public class VariableScope : MonoBehaviour
    {
        // [1] 정의 : 필드 선언부.
        string globalVariable = "전역변수";     // ) = Field(필드, 전역변수, 멤버변수)
        void Start()
        {
            // [1-1] 정의 : 지역변수 선언 및 사용.
            string localVariable = "지역변수";
            Debug.Log(localVariable);
            // [1-2] 정의 : 전역변수 선언.
            Debug.Log(globalVariable);
        }
        void TestPrint()
        {
            // [2] 가정 : 전역변수 사용.
            Debug.Log(globalVariable);
            // ) Debug.Log(localVariable); → NG.

        }
    }
}