using UnityEngine;


/* [0] ���� : ArraySort
		- Sort(����)
		    - ��������(1, 2, 3...)
		    - ��������(9, 8, 7...)
*/


public class ArraySort : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� : ��������(Sort) ����.
        int[] arr = { 3, 2, 1, 5, 4 };

        // [2] ����
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
        Debug.Log("==============");

        // [3-1] ���
        System.Array.Sort(arr);
        foreach (var num in arr)
        {
            Debug.Log("==============");
        }
        // [3-2] ���
        System.Array.Reverse(arr);
    }
}
