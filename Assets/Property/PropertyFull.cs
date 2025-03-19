using UnityEngine;

/* [0] 개요 : PropertyFull
*/

namespace Property
{
    public class PropertyFull : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 정의 : Person Class의 인스턴스 생성.
            Person person = new Person();
            // [1-2] 정의 : 메서드를 이용하여 Name값 저장 및 사용.
            person.SetName("홍길동");
            // [1-3] 결과
            Debug.Log(person.GetName());

            // [2-1] 정의 : Property를 이용하여 Name값 저장 및 사용. → Name의 Property의 get을 이용함.
            person.Name = "백두산";        // ) Person Class의 Set = Value로 감.
            // [2-2] 결과 : Person Class의 Get으로 감.
            Debug.Log(person.Name);
        }
    }
}
