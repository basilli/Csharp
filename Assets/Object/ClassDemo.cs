using UnityEngine;


/* [0] 개요 : ClassDemo
		- ClassOne, ClassTwo 클래스를 사용.
		- 다른 클래스의 멤버를 호출.
*/


public class ClassDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 가정 : Static 멤버 호출.
        ClassOne.Hi();      // ) 반갑습니다. 출력.
        ClassTwo.Hi();      // ) 안녕하세요. 출력.
        // [1-2] 가정 : Instacne 멤버 호출 → 다른 클래스의 인스턴스 생성.
        ClassTwo two = new ClassTwo(); // ) new를 쓰지말라고 경고창이 뜸.
        two.Hello();        // ) 또 만나요. 출력.
    }
}
