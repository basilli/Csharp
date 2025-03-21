using UnityEngine;

/* [0] 개요 : ChildClass
*/
namespace Inheritance04
{
    public class ChildClass : ParentClass
    {
        // [1] 정의
        public void PrintMessage2()
        {
            PrintMessage1();        // ) ParentClass의 PrintMessage1를 가져옴.
        }
    }
}
