using UnityEngine;
using System.Linq;


/* [0] 개요 : LinqAverage
		- using System.Linq;을 상부에 추가할 것.
*/

public class LinqAverage : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 정수형 배열 요소들의 평균 구하기.
        int[] numbers = { 1, 2, 5 };
        // [2] 가정
        double average = numbers.Average();
        // [3] 결과
        Debug.Log($"numbers 배열 요소들의 평균값은 {average:#.##}");
    }
}
