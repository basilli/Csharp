using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



/* [0] 개요 : MaxPractice
		- using System.Collections;을 상부에 추가할 것. → Stack를 사용할 경우, 자동추가됨.
		- using System.Collections.Generic;을 상부에 추가할 것.
		- using System.Linq;을 상부에 추가할 것.
		- [Q]
            - 입력데이터 {-2, -5, -3, -7, -1}
            - 입력데이터 중에서 최댓값을 구하시오.
        - [output]
            - 최댓값 : -1
*/


public class MaxPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int[] data = { -2, -5, -3, -7, -1 };

        // [2-1] 가정 : 최대값을 저장하는 변수(Max의 초기화 값 : Max의 데이터 타입이 가지는 값 중 가장 작은 값)
        int max = int.MinValue;
        // [2-2] 가정 : 두 수 비교 후 큰값을 max에 저장함.
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] > max)
            {
                max = data[i]; 
            }
        }
        // [3] 결과
        Debug.Log($"최댓값은 {max}");
    }
}
