using UnityEngine;


/* [0] 개요 : ArrayTwo
		- 2차원배열 : 행과 열로 이루어진 배열.
		-      ←열→
          행  1, 2, 3
          ↓  4, 5, 6  
		- 
		- 
		- 
*/
public class ArrayTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
            // [1-1] 배열 선언
            int[,] intArray;
            // [1-2] 배열 요소수(크기) 생성
            intArray = new int[2, 3];       // ) [행 = 가로 = y, 열 = 세로 = x]
            // [1-3] 배열 초기화
                // 0번행
                intArray[0, 0] = 1;
                intArray[0, 1] = 2;
                intArray[0, 2] = 3;
                // 1번행
                intArray[1, 0] = 4;
                intArray[1, 1] = 5;
                intArray[1, 2] = 6;
            // [1-4] 배열 사용
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                Debug.Log(intArray[i, j]);
                }
            }
    }
}
