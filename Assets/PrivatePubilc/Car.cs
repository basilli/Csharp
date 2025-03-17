using UnityEngine;

/* [0] 개요 : Car
*/

namespace PrivatePublic
{

    public class Car
    {
        // [1] 정의 : 필드(전역변수, 멤버변수) → Public, Private 둘 다 가능함.
        public string name;     // ) 이름
        private int age;        // ) 나이
        string address;     // ) 주소 → 접근제한자가 생략되면 기본값이 Private로 설정됨.

        // [2-1] 가정 : Public 멤버 메서드.
        public void Hi()
        {
            Debug.Log("Hola.");
        }
        // [2-2] 가정 : Private 멤버 메서드.
        private void Bye()
        {
            Debug.Log("Buenas noches.");
        }
    }
}
