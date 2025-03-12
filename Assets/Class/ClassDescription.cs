using UnityEngine;

/* [0] 개요 : ClassDescription
		- C#에서 가장 기본이 되는 구문.
		- 하나의 이름으로 서로 다른 형식의 데이터와 함수를 묶어서 관리하는 그릇(구문)
        - 사용자 정의 데이터 형식.
        - 형태
            public class (클래스 명)
            {
            
            }
		- 유니티이서 Script를 새로 생성할 때, 하단을 보면 Scripting → Empty C# Script가 기본형태임.
		- 속성(필드, 프로퍼티)과 동작(메서드)을 정의하는 데이터 구조→ 현실 세계의 사물을 코드로 표현하는 설계도.
		- 클래스를 기반으로 객체를 만들어 사용.
        - 한 번 정의한 클래스를 여러 곳에서 재사용 가능하여 유지보수 및 확장성이 뛰어남.
        - 데이터를 외부에서 직접 접근하지 못하도록 보호하고, 필요한 기능만 제공할 수 있음.
        - 불필요한 정보는 숨기고 필요한 정보만 제공하여 코드의 복잡성을 줄임.
        - 기존 클래스를 확장(상속)하여 새로운 기능을 추가할 수 있음.
*/

public class ClassDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [3] 가정 : 메서드 호출.
        Run();      // ) 같은 Class의 메서드 호출.
        ClassDescription.Run();     // ) Class 레벨의 메서드 호출. (ex. 클래스이름.메서드( ) 호출)
    }
    // [1] 정의 : ClassDescription이라는 Class의 Run(정적) 메서드(함수).
    static void Run()
    {
        Debug.Log("ClassDescription이라는 클래스의 Run( ) 메서드");
    }
}
