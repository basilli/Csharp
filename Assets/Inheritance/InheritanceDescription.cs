using Inheritance;
using UnityEngine;

/* [0] 개요 : InheritanceDescription
		- Inheritance(상속) : 부모Class가 자신의 기능을 자식Class에게 물려주어 사용 가능하게 해줌.
		- 부모Class (=BaseClass, SuperClass, 기본Class. → 자식Class를 여러개 가질 수 있음.)
            : 자식Class들의 공통기능을 모아놓은 Class.
		- 자식Class (=SubClass)
		- 손자Class
            : 자식의 자식Class
            : 부모와 자식Class 기능을 모두 물려받음.
*/


public class InheritanceDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : Child Class의 인스턴스 생성.
        Child child = new Child();
        child.Foo();        // ) Child Class가 Parent Class의 메서드를 호출함.
        child.Bar();        // ) Child Class가 Child Class의 메서드를 호출함.
    }
}
