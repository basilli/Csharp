using UnityEngine;

/* [0] 개요 : BaseClass
*/
namespace Inheritance04
{
    public class SubClass : BaseClass       // ) ' : BaseClass ' 를 Parent로 선택함.
    {
        // [1] 정의 : Child
        public void PrintDebug()
        {
            base.PrintLog();     // ) Base.이라는 키워드를 이용하여 ParentMember에 접근이 가능함.
        }
    }
}
