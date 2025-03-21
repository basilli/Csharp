using UnityEngine;

/* [0] 개요 : My
*/

namespace Inheritance05
{
	public class My : Car       // ) Car를 ParentClass로 하는 ChildClass.
    {
        // [1] 정의
        public My() : this("나의 자동차")        // ) this = 자신의 객체.
        { 
        
        }

        public My(string _name) : base(_name)       // ) base = 부모의 객체.
        {
            // ) base.name = _name; → NG.
        }
    }
}
