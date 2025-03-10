using UnityEngine;

/* [0] 개요 : ArrayOne
        - 1차원 배열을 선언하고 초기화.
 */
public class ArrayOne : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        // [1-1] 배열선언
        int[] intArray;

        // [2] 가정
        // [2-1] 배열 요소수 생성(크기 결정 및 메모리 영역 확보)
        intArray = new int[3];      // ) 방이 0,1,2가 만들어짐
        // [2-2] 배열 초기화
        intArray[0] = 1;
        intArray[1] = 2;
        intArray[2] = 3;

        // [3] 결과

        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"{i}번째 방의 값은 : {intArray[i]} 이다.");
        }

        /* [A] 배열의 사용
        Debug.Log($"0번째 방의 값은 : {intArray[0]} 입니다.");
        Debug.Log($"1번째 방의 값은 : {intArray[1]} 입니다.");
        Debug.Log($"2번째 방의 값은 : {intArray[2]} 입니다.");
        */
    }
}
