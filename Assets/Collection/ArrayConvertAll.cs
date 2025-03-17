using UnityEngine;


/* [0] 개요 : ArrayConvertAll
*/

public class ArrayConvertAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 문자열 배열을 정수형 배열로 변경.
        string[] strArray = { "10", "20", "30" };

        // [2] 가정
        int[] intArray = System.Array.ConvertAll(strArray, int.Parse);

        // [3] 결과
        foreach (int i in intArray)
        {
            Debug.Log(i);
        }
    }
}
