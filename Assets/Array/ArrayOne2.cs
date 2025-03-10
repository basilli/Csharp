using UnityEngine;


/* [0] 개요 : ArrayOne2
 */
public class ArrayOne2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        // [1-1] 배열선언 + 요소수(갯수 및 크기) 생성 + 값 초기화를 동시에 진행.
               // int[] intArray = new int[3] { 1, 2, 3 };
        // [1-2] 배열선언 + 값 초기화를 동시에 진행.
               // int[] intArray = new int[] { 1,2,3,4 };     // ) new int[]에 값을 넣지않고 { }에 입력한 수대로 방이 생성됨.
        // [1-3] 배열선언 + 값 초기화를 동시에 진행.
             int[] intArray = { 1, 2, 3, 4 };

        // [2] 결과
        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"{i}번째 방의 값은 : {intArray[i]} 이다.");
        }
    }
}
