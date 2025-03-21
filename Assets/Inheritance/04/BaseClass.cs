using UnityEngine;

/* [0] 개요 : BaseClass
*/
namespace Inheritance04
{
    public class BaseClass : System.Object      // ) 모든 Class는 ObjectClass로부터 상속을 받음.
    {
        // [1] 정의 : ParentClass
        protected void PrintLog()
        {
            Debug.Log("ParentClass의 메서드에서 호출");
        }
    }
}
