using UnityEngine;

/* [0] 개요 : MethodVirtual Animal
        - public virtual void(메서드이름) : 가상 메서드.
*/

namespace Override
{
    // [1-1] 정의 : ParentClass 선언.
    public class Animal
    {
        public virtual void Eat() => Debug.Log("Animal Eat");
    }

    // [1-2] 정의 : ChildClass 선언.
    public class Dog : Animal
    {
        public override void Eat()
        {
            {
                Debug.Log("강아지가 밥을 먹는다.");
            }
        }
    }

    // [1-3] 정의 : ChildClass 선언.
    public class Cat : Animal
    {
        public override void Eat()
        {
            base.Eat();     // ) ParentMethod에서 구현된 내용을 모두 실행함.
            Debug.Log("고양이가 밥을 먹는다.");      // ) Override에서 새로 추가된 내용을 실행함.
        }
    }
}
