using UnityEngine;


/* [0] 개요 : DestructorTest
*/

namespace Constructor
{

    public class DestructorTest
    {
        // [1-1] 정의 : Constructor
        public DestructorTest()
        {
            Debug.Log("[1] 생성");
        }
        // [1-2] 정의 : 메서드
        public void Run()
        {
            Debug.Log("[2] 실행");
        }
        // [1-3] 정의 : Destructor
        ~DestructorTest()
        {
            Debug.Log("[3] 소멸");
        }
    }
}
