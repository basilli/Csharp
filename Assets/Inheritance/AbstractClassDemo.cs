using UnityEngine;

/* [0] 개요 : AbstractClassDemo
		- AbstractClass(추상클래스) : 자신을 상속받는(=Parent의 입장에서) ChildClass에 강제로 기능을 추가하도록 함.
		- ChildClass는 ParentClass가 지정한 기능을 구현하도록 강제함.
		- AbstractClass는 인스턴스를 만들 수 없음. → 다른 Class의 ParentClass만 사용이 가능함.
		- 형태
            public abstract class (추상클래스이름)
            {
            
            }
*/

namespace Inheritance08
{
    public class AbstractClassDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 정의
            ChildClass child = new ChildClass() { ID = 1, Active = true, Name = "홍길동" };
            if (child.Active == true)
            {
                Debug.Log($"{child.ID} - {child.Name}");
            }
            // ) ParentClass parent = new ParentClass(); → NG.(AbstractClass는 인스턴스를 만들 수 없음.)
        }
    }
}
