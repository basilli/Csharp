using UnityEngine;

/* [0] 개요 : Parent
*/

namespace Override
{
    // [1-1] 정의 : ParentClass 선언.
    public class Parent
	{
        public void Say() => Debug.Log("Parent 인사하다.");
        public void Run() => Debug.Log("Parent 달린다.");
        public virtual void Work() => Debug.Log("Parent 걷다.");
    }

    // [1-2] 정의 : ChildClass 선언.
    public class Child : Parent
    {
        // ) public void Say() => Debug.Log("Child 인사하다."); → Parent.Say가 생략이 됨.
        public new void Say() => Debug.Log("Child 인사하다.");
        public new void Run() => Debug.Log("Child 달린다.");
        public override void Work() => Debug.Log("Child 걷다.");
    }
}
