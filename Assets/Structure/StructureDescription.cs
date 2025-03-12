using UnityEngine;


/* [0] 개요 : StructureDescription
        - Variable(변수) : 데이터를 저장하는 그릇
        - Array(배열) : 하나의 이름으로 같은 형식의 데이터를 여러개 담는 그릇. (묶음, 변수의 확인)

		- Structure(구조체) : 하나의 이름으로 서로 다른 형식의 데이터나 함수를 묶어서 관리하는 그릇. (데이터 구조) → 사용자 정의 데이터 형식.
		- 형태
            // 구조체 형식
            struct (구조체 이름)
            {
                // 서로 다른 형식의 데이터
                // 함수
            }

		- 클래스(class)와 비슷하지만 가벼운 데이터 타입으로, 값 타입(Value Type) 으로 동작해서, 객체보다 메모리를 적게 사용함. → 주로 작은 데이터 그룹을 저장할 때 사용.
        - 기본적으로 생성자 없이도 사용 가능하지만, 필요에 의하여 생성자를 만들 수 있음.
*/

// [1] 정의 : 두개의 정수를 관리하는 구조체 만들기.
struct Point
{
    public int x;       // ) public : 키워드를 선언할 경우, 외부에서 int x 변수를 사용가능하도록 설정함. → struct의 코드블럭({ })의 외부에서 사용이 가능함.
    public int y;
}

public class StructureDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2-1] 가정 : 구조체 형식의 변수 선언.
        Point p;

        // [2-2] 가정 : Point 구조체의 x,y 변수에 값을 저장(대입, 할당) 초기화.
        p.x = 100;
        p.y = 200;

        // [3] 결과
        Debug.Log($"X = {p.x}, Y = {p.y}");
    }
}