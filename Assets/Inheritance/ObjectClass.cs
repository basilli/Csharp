using UnityEngine;

/* [0] 개요 : ObjectClass
		- static 메서드는 Class의 인스턴스를 생성하지 않고 호출.
		- static 메서드 호출 방법 : 클래스이름.메서드이름
*/

namespace Inheritance
{
    public class ObjectClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 정의 : static 메서드는 Class의 인스턴스를 생성하지 않고 호출.
            ChildClass.Hi();        // ) Child가 Parent를 불러냄.
            ChildClass.Hello();        // ) Child가 Child를 불러냄.

            // [1-2] 정의  : ParentClass와 ChildClass의 인스턴스 생성.
            ParentClass parent = new ParentClass();
            Debug.Log(parent.ToString());
            ChildClass child = new ChildClass();
            Debug.Log(child.ToString());
        }
    }
}
