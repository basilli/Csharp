using UnityEngine;


/* [0] 개요 : StructureNote
		- 명함 데이터를 관리하는 구조체를 만드시오.
*/

// [1] 정의
struct BusinessCard
{
    public string name;     // ) 고객이름
    public int age;     // ) 고객나이
    public string address;      // ) 고객주소
}

public class StructureNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2-1] 가정 : 구조체 형식의 변수 선언.
        BusinessCard mycard;

        // [2-2] 가정 : 구조체에 속해있는 데이터 초기화.
        mycard.name = "홍길동";
        mycard.age = 20;
        mycard.address = "서울특별시 강동구";

        // [3] 결과
        Debug.Log($"이름 : {mycard.name}, 나이 : {mycard.age}, 주소 : {mycard.address}");
    }
}
