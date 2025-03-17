using UnityEngine;
using System.Collections;


/* [0] 개요 : HashTableDemo
		- HashTable를 사용하려면 상부에 적힌 'using System.Collections;을 추가해야함.
		- HashTable : 정수 형식, 문자열 형식의 인덱스를 사용하여 데이터를 저장 및 관리하는 클래스
		- [0], [1], [2], ["문자열"], ["이름"]
*/

public class HashTableDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : HashTable 클래스의 객체(인스턴스) 생성.
        Hashtable hash = new Hashtable();

        // [2] 가정 : 인덱스를 사용하여 데이터 입력.
        hash[0] = "대한민국";
        hash["시 이름"] = "서울특별시";
        hash["구 이름"] = "강동구";

        // [3-1] 결과 : 인덱스를 사용하여 데이터 출력.
        Debug.Log(hash[0]);
        Debug.Log(hash["시 이름"]);
        Debug.Log(hash["구 이름"]);
        // [3-2] 결과 : 반복문을 사용하여 데이터 출력.
        foreach (var o in hash.Keys)        // ) 데이터를 가져올 때는 반드시 var로 해야함.
        {
            Debug.Log($"{o.ToString()} - {hash[o]}");
        }
    }
}

