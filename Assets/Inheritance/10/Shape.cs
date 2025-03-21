using UnityEngine;

/* [0] 개요 : Shape
        - AbstractClass : 도형을 관리하는 Class.
        - AbstractMethod 기능 : 도형의 면적을 구하는 Method를 구현하도록 지정함.
*/

namespace Inheritance10
{
    // [1-1] 정의 : AbstractClass
    public abstract class Shape
	{
        // [1-2] 정의 : AbstractMethod
        public abstract double GetArea();
    }
}
