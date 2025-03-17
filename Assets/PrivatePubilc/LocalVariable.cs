using UnityEngine;


/* [0] 개요 : LocalVariable
		- Field(필드, 전역변수, 멤버변수)
            - 클래스의 부품역할을 하는 클래스 내부 상태값을 저장하는 그릇(변수).
            - 대부분의 Field 선언부에서 선언하고 또 초기화함.
            - 액세스 한정자를 지정함. → 접근 제한자, 기본 엑세스 한정자는 private.
                - public : 접근에 제한이 없음.
                - private : 해당(현재) 클래스 안에서만 접근이 가능함.
                - protected : 해당(현재) 클래스 안에서만 접근이 가능함. + 상속받은 자식 클래스에서 접근이 가능함.
                - internal : 해당 프로젝트 내에서 접근이 가능.
                - protected internal : 
            - 네이밍 : 스타일.
                - 변수의 맨 앞글자의 알파벳은 소문자로 시작한다.
                - 변수 중간에 단어로 연결될 때, 단어는 대문자로 시작한다.
                - m_name
                - 상수, 읽기전용 변수의 첫 알파벳은 대문자로 시작한다.
*/

namespace PrivatePublic
{

public class LocalVariable : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()        // ) private가 생략되어있음.
    {
            // [1] 정의 : LocalVarialbe(지역변수) 선언
            int i = 1234;
            int j = 4567;

            // [2] 결과 : 지역변수 사용
            Debug.Log(i+j);
        }
    }
}