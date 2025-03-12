using UnityEngine;


/* [0] 개요 : StringSplit
		- Split( ) : 문자열 분리하기.
		- 문자열에서 매개변수로 입력받은 특정 구분문자를 사용하여, 문자열 배열을 만듬.
*/

public class StringSplit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        string scr = "Red,Green,Blue";
        string[] colors = scr.Split(',');

        // [2] 결과
        for (int i = 0; i < colors.Length; i++)
        {
            Debug.Log(colors[i]);
        }
    }
}
