using System;
using UnityEngine;
using System.Linq;

/* [0] 개요 : Question 2
		- [Q] 입력받은 데이터 중 최소값을 구하는 프로그램 구현 하세요.
                { -2, -5, -3, -7, -1 }
		- [A] 출력형태 
                최소값은 -7
*/

public class QuestionTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    // [1-1] 정의 
        int[] number = { -2, -5, -3, -7, -1};
        int minValue = number[0];
    // [1-2] 가정
        foreach (var num in number)
        {
            minValue = Math.Min(minValue, num);
        }
    // [1-3] 결과
        Debug.Log($"최솟값은 {minValue}");
    }
}