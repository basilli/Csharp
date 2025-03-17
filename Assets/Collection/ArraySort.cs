using UnityEngine;


/* [0] 개요 : ArraySort
		- Sort(정렬)
		    - 오름차순(1, 2, 3...)
		    - 내림차순(9, 8, 7...)
*/


public class ArraySort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 오름차순(Sort) 정렬.
        int[] arr = { 3, 2, 1, 5, 4 };

        // [2] 가정
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
        Debug.Log("==============");

        // [3-1] 결과
        System.Array.Sort(arr);
        foreach (var num in arr)
        {
            Debug.Log("==============");
        }
        // [3-2] 결과
        System.Array.Reverse(arr);
    }
}
