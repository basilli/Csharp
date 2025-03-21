using UnityEngine;

/* [0] 개요 : ParentClass
*/

namespace Inheritance04
{
    public class ParentClass : System.Object
    {
        // [1] 정의
        protected void PrintMessage1()
        {
         Debug.Log("ParentClass에서 정의한 내용");
        }
    }
}
