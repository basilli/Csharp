using UnityEngine;

/* [0] 개요 : InheritanceClass
		- 접근제한자 : Public, Private, Protected
            - Public : 외부 Class에서 접근 및 사용 가능.
            - Private : 외부 Class에서 접근 및 사용 불가능.
            - Protected : Private와 동일하나, 상속받은 ChildClass의 코드블록( {} ) 안에서만 접근 및 사용 가능.
*/

namespace Inheritance04
{
    public class InheritanceClass : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 정의 : ParentClass의 인스턴스 생성.
            ParentClass parent = new ParentClass();
                    // ) parent.PrintMessage1(); → NG.
            Debug.Log(parent.ToString());

            // [1-2] 정의 : ChildClass의 인스턴스 생성.
            ChildClass child = new ChildClass();
                    // ) child.PrintMessage1(); → NG.
            child.PrintMessage2();

            // [1-3] 정의 : SubClass의 인스턴스 생성.
            SubClass subClass = new SubClass();
            // ) subClass.PrintLog(); → NG.
        }
    }
}
