using Inheritance;
using UnityEngine;

/* [0] 개요 : MethodOverrideDescription
		- MethodOverride(메서드재정의)
		- ParentClass의 Method를 재정의해서 사용.
*/

namespace Override
{
    public class MethodOverrideDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] rufrhk : ChildClass의 인스턴스 생성.
            Child child = new Child();
            child.Say();
            child.Run();
            child.Work();
        }
    }
}
