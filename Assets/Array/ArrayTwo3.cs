using UnityEngine;


/* [0] 개요 : ArrayTwo3
		- 가변형 배열 : 배열의 길이가 가변임.
*/

public class ArrayTwo3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        // [1-1] 2차원 배열 선언 : 가변형일경우 첫번째 요소수(크기)만 생성.
        int[][] intArray = new int[2][];       // ) = int[,] intArray;
        // [1-2] 2차원 배열 (두번째)요소수(크기) 생성 + 초기화 : 각각 따로 생성.
        intArray[0] = new int[3] { 1,2,3 };       // ) [0]은 행을 가르킴.
        intArray[1] = new int[2] { 4,5 };       // ) [1]은 열을 가르킴.
        // [1-3] 배열의 길이
        Debug.Log($"배열의 길이 : {intArray.Length}");       // ) 배열의 길이가 2가 나옴 → 가변형일 경우 [1-1]에서 new int [2][]에서 [2]를 가르킴.
        // [1-4] 2차원 배열 사용
        for (int i = 0; i < intArray.Length; i++)
        {
            for (int j = 0; j < intArray[i].Length; j++)
            {
                Debug.Log(intArray[i][j]);
            }
            Debug.Log("========================");
        }
    }
}
