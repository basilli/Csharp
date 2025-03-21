using UnityEngine;

/* [0] 개요 : Circle
		- 원을 관리하는 Class.
		- Square(AbstractClass)를 상속받는 ChildClass.
*/

namespace Inheritance10
{
    // [1-1] 정의 : Square를 ParentClass라고 선언.
    public class Circle : Shape
	{
        // [1-2] 정의 : Field.
        private int size;       // ) 반지름의 길이.
        // [1-3] 정의 : Constructor.
        public Circle(int _size)
        {
            this.size = _size;
        }

        // [2-1] 가정 : ParentClass의 AbstractMethod(GetArea)를 구현.
        public override double GetArea()
        {
            return size * size*3.14;
        }
    }
}
