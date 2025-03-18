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
        // [2-3] 가정 : Private한 필드(age)를 외부에 공개하고자 할 때, Public한 메서드를 이용함. → 매개변수로 나이를 입력받아, age에 저장하는 함수.
        public void SetAge(int nai)
        {
            age = nai;
        }
        // [2-4] 가정 : age를 반환하는 함수.
        public int GetAge()
        {
            return age;
        }
    }
}
