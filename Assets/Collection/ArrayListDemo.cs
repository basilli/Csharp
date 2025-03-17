using UnityEngine;
using System.Collections;


/* [0] 개요 : ArrayListDemo
		- ArrayList를 사용하려면 상부에 적힌 'using System.Collections;을 추가해야함.
		- ArrayList 클래스 : 배열과 같은 구조, 배열처럼 사용이 가능함(인덱스 사용).
		- Add ( ) 데이터 넣기.
*/

public class ArrayListDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : ArrayList 클래스의 객체(인스턴스) 생성.
        ArrayList list = new ArrayList();

        // [2] 가정 : 데이터 입력.
        list.Add("서울특별시");
        list.Add("강동구");

        // [3] 결과 : 데이터 출력.
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i].ToString());
        }
    }
}
