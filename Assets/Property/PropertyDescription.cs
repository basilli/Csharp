using Property;
using UnityEngine;


/* [0] 개요 : PropertyDescription
		- Property(속성) : Field값을 읽거나 쓰거나 연산하는 방법을 제공하는 Class 멤버.
		- Field는 기본적으로 Private으로 설정됨. → 외부에서 접근이 제한됨.
		- Property(속성)은 접근제한된 Field를 외부에서 읽거나 쓰기가 가능하도록 해줌.
        - Property(속성)이름은 맨 앞은 대문자를 쓴다.
		- 형태
            public [반환타입] 속성이름 {get; set;}
*/

namespace Method
{
    public class PropertyDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-1] 정의 : Developer Class의 인스턴스 생성.
            Developer dev = new Developer();
            // [1-2] 정의 : Property의 값 설정.
            dev.Name = "홍길동";

            // [2] 결과 : Property의 값 사용.
            Debug.Log(dev.Name);
        }
    }
}

