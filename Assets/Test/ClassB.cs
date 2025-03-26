using Unity.VisualScripting;
using UnityEngine;


/* [0] 개요 : Question 1
		- [Q] 클래스(A) 만들기.
            - 필드(멤버변수) string 배열 선언하고 { 일, 월, 화, 수, 목, 금, 토 } 값으로 초기화 하기
            - 인스턴스 멤버 함수 만들기 : 필드에서 선언된 배열 값을 출력하는 기능 구현
            - 정적(static) 멤버 함수 만들기 : 두 개의 정수를 매개 변수로 받아서 더하기 한 후 합을 결과 값으로 반환하는 기능 구현
		- [Q] 클래스(B) 만들기.
            - 클래스(A)의 인스턴스 함수를 호출하기
            - 클래스(A)의 정적 함수를 호출하여 결과값을 반환 받아 출력하기 : 매개변수(5, 6)
		- [A]
            일
            월
            화
            수
            목
            금
            토
            11
*/
public class ClassB : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClassA a = new ClassA();
        a.Printday();

         int number = ClassA.Add(5,6);
        Debug.Log($"{number}");
    }
}
