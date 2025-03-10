using UnityEngine;


/* [0] 개요 : ArrayPractice
		- [Q]
            - 3행 3열의 2차원 배열을 만드시오.
            - 배열의 값을 행과 열의 인덱스가 같으면 1, 행과 열의 인덱스가 틀리면 0으로 저장하시오
		    - 저장하는 방법을 이중 for문을 사용하시오. 
		- [output]
            - arr[0,0] : 1
            - arr[0,1] : 0
                ...
            - arr[2,2] :1
		        1, 0, 0
                0, 1, 0
                0, 0, 1
*/
public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        // [1-1] 2차원 배열 : 3행 3열
        int[,] arr = new int[3,3];
        // [1-2] 배열의 길이
        Debug.Log($"배열의 길이 : {arr.Length}");
        // [1-3] 2차원 배열 사용
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)     // ) 행과 열의 인덱스가 같으면 1
                {
                    arr[i, j] = 1;
                }
                else     // ) 행과 열의 인덱스가 틀리면 0
                {
                    arr[i, j] = 0;
                }
            }
        }

        // [2] 결과
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log($"arr[{i},{j}] : {arr[i, j]}");
            }
        }

    }
}


/* [A]
    // [1] 정의
        // [1-1] 2차원 배열 선언 : 가변형
        int[][] intArray = new int[3][];
        // [1-2] 2차원 배열 생성 + 초기화
        intArray[0] = new int[3] { 1, 0, 0 };
        intArray[1] = new int[3] { 0, 1, 0 };
        intArray[2] = new int[3] { 0, 0, 1 };
        // [1-3] 배열의 길이
        Debug.Log($"배열의 길이 : {intArray.Length}");
        // [1-4] 2차원 배열 사용
        for (int i = 0; i < intArray.Length; i++)
        {
            for (int j = 0; j < intArray[i].Length; j++)
            {
                Debug.Log(intArray[i][j]);
            }
        }
 
 */


/* [B]
    // [1] 정의
        // [1-1] 2차원 배열 선언 + 요소수 생성(생략) + 초기화
        int[,] intArray = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
        // [1-2] 배열의 길이
        Debug.Log($"배열의 길이 : {intArray.Length}");
        // [1-3] 출력
        for (int i = 0; i < intArray.GetLength(0); i++)
        {
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log(intArray[i, j]);
            }
        }
 */