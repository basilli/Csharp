using UnityEngine;
using System.Collections;
using System.Collections.Generic;


/* [0] 개요 : ListOfInt
		- using System.Collections;을 상부에 추가할 것.
		- using System.Collections.Generic;을 상부에 추가할 것.
		- Array와 GenericList를 비교하려고 함.
*/

public class ListOfInt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 정의 : Array, 정수형 배열 선언 + 요소수 생성.
        int[] arrNumbers = new int[2];
        // [1-2] 가정 : Array, 초기화
        arrNumbers[0] = 10;
        arrNumbers[1] = 20;
        // [1-3] 결과 : Array, 사용.
        for (int i = 0; i < arrNumbers.Length; i++)
        {
            Debug.Log(arrNumbers[i]);
        }

        // [2-1] 정의 : GenericList, List<T>를 이용하여, int형 전용 List의 인스턴스 생성.
        List<int> listNumbers = new List<int>();
        // [2-2] 가정 : GenericList, 데이터 입력.
        listNumbers.Add(30);
        listNumbers.Add(40);
        // [2-3] 결과 : GenericList, 데이터 출력.
        for (int i = 0; i < listNumbers.Count; i++)
        {
            Debug.Log(listNumbers[i]);
        }
    }
}
