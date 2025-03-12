using UnityEngine;


/* [0] 개요 : EnumerationDescription
		- Enumeration(열거형) : 하나의 이름으로 서로 관련있는 정수 값을 갖는 상수들의 집합.
		- 형태
            enum (enum 이름)
            {
                상수명,
                상수명,
                상수명,
                ETC...
            }
		- 관련된 상수들의 집합을 정의하는 데이터 타입 → 요일, 색상, 상태 등을 나타낼 때 enum을 사용하면 더 직관적이고 가독성이 좋아짐.
        - 서로 연관된 정수형 상수들의 집합.
        - 기본적으로 0부터 시작하는 정수 값을 자동으로 할당함.
        - 특정 상태나 옵션을 의미 있는 이름으로 표현할 수 있음.
        - 코드의 가독성과 유지보수성을 높여줌..
*/

// [1] 정의 : 우선순위를 관리하는 열거형 생성(선언, 만들기). → 사용자 정의 데이터 형식.
enum Priority
{ 
    High,
    Normal,
    Low,
}

public class EnumerationDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 가정 : 열거형 변수 선언 및 초기화. → 열거형 변수에는 저장되는 값은 정의에서 만들어진 상수값만 가능함.
        Priority high = Priority.High;
        Priority normal = Priority.Normal;
        Priority low = Priority.Low;

        // [3] 결과
        Debug.Log($"{high}, {normal}, {low}");
    }
}
