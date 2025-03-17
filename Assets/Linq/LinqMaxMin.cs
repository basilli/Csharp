using NUnit.Framework.Internal.Builders;
using System.Linq;
using UnityEngine;

/* [0] 개요 : LinqMaxMin
		- using System.Linq;을 상부에 추가할 것.
*/


public class LinqMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 정수형 배열 numbers의 요소 중 최댓값, 최솟값 구하기.
        int[] numbers = { 1, 2, 3 };
        int max = 0;
        int min = 0;
        // [2] 가정 : 변수 초기화.
        max = numbers.Max();
        min = numbers.Min();
        // [3] 결과
        Debug.Log($"numbers의 최대값 : {max}, 최솟값 : {min}");
    }
}
