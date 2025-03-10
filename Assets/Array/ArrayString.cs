using UnityEngine;


/* [0] 개요 : ArrayString
        - string : 문자의 (배)열. → Array(배열)과 연관이 있음.
 */
public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        string arr = "C#8";

        // [2] 결과
        Debug.Log(arr.Length);
        Debug.Log(arr[0]);       // ) C가 입력됨.
        Debug.Log(arr[1]);       // ) #가 입력됨.
        Debug.Log(arr[2]);       // ) *가 입력됨.
    }
}
