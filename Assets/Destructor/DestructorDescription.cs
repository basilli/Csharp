using UnityEngine;


/* [0] 개요 : DestructorDescription
		- Destructor(소멸자) : Class가 사용 된 후, 가장 마지막에 호출되는 메서드.
		- 생선된 인스턴스가 메모리에 없어질 때 호출되는 메서드. → Class에서 사용된 메모리 해체 등
		- C#에서 메모리 해제 : GC(Garbage Collector)가 메모리 해제 역할을 대신 해줌.
		- 형태.
            class ClassName
            {
                //소멸자
                ~ClassName()
                {
                    // 개체가 소멸할 때 필요한 기능을 수행.
                }
            }
*/

namespace Constructor
{
    public class DestructorDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 결과 : DestructorTest Class의 인스턴스 생성.
            DestructorTest destructorTest = new DestructorTest();
            // [1-2] 결과 : 인스턴스 생성.
            destructorTest.Run();
            // [1-3] 결과 : GC.Collect → DestructorTest Class의 Desctructor 호출.
            // ) ~DestructorTest(); → NG.
        }
    }
}
