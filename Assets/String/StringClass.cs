using UnityEngine;

/* [0] 개요 : StringClass
		- string == System.String
		- 문자(배)열 길이 구하기 = 배열이름.Length
*/

public class StringClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        string s1 = "Hello.";
        System.String s2 = "반갑습니다.";
        // [2] 결과
        Debug.Log($"{s1}의 길이 : {s1.Length} , {s2}의 길이 : {s2.Length}");
    }
}
