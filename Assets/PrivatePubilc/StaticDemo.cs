using UnityEngine;


/* [0] 개요 : StaticDemo
*/

namespace PrivatePublic
{

    public class StaticDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 결과 : PublicPrivate 클래스의 Static Field 및 Static 메서드 사용. → 형태 : 클래스이름. 필드이름 or 클래스이름.메서드이름
            PublicPrivate.name = "홍길동";
            // ) Debug.Log(PublicPrivate.name); →OK.

            // [1-2] 결과
            string sName = PublicPrivate.GetName();
            Debug.Log(sName);
            // ) PublicPrivate.age = 22; → NG.

            // [1-3] 결과 : PublicPrivate의 객체생성.
            PublicPrivate publicPrivate = new PublicPrivate();
            publicPrivate.SetAge(22);
            // ) publicPrivate.age = 22; → NG.
            int myAge = publicPrivate.GetAge();
            Debug.Log(myAge);
        }
    }
}
