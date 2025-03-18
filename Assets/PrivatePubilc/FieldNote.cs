using UnityEngine;


/* [0] 개요 : FieldNote
*/

namespace PrivatePublic
{


    public class FieldNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] 결과 : Person 클래스의 인스턴스 생성.
            Person person = new Person();
            person.ShowProfile();
        }
    }
}
