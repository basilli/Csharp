using UnityEngine;

/* [0] 개요 :  ChildClass
*/

namespace Inheritance
{
    public class ChildClass : ParentClass       // ) ' : ParentClass ' 를 Parent Class를 선택함.
    {
        // [1] 정의
        public static void Hello()
        {
            Debug.Log("Encantada!");
        }
    }
}