using UnityEngine;
using System.Collections.Generic;

/* [0] 개요 : GenericMethod
 * 		- using System.Collections.Generic;을 상부에 추가할 것.
*/

namespace GenericClass
{

    public class GenericMethod : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 정의 : HelloClass 인스턴스 생성.
            Hello<int> hi = new Hello<int>();
            hi.Say(1234);
            Hello<string> hs = new Hello<string>("Hola!");
            hs.Say(hs.GetMessage());

        }
    }
}