using UnityEngine;


/* [0] 개요 : FieldInitialize
*/

// [1-1] 정의
namespace PrivatePublic
{

    public class FieldInitialize : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-2] 정의 : Say 클래스의 인스턴스 생성.
            Say say = new Say();
            say.Hi();
        }
    }
}
