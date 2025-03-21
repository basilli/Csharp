using UnityEngine;

/* [0] 개요 : InheritanceConstruct
*/

namespace Inheritance06
{
    public class InheritanceConstruct : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 정의 : ChildClass의 인스턴스 생성.
            Child child1 = new Child();
            child1.SayName();
            Child child2 = new Child("백두산");
            child2.SayName();

            // [2] 가정
            // [3] 결과
        }
    }
}
