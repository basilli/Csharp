using UnityEngine;

public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int i = 100;
        int j = 200;
        int temp;
        Debug.Log($"처음 i : {i}, j : {j}");

        // [2] 자리바꾸기
        temp = i;   // 임시변수(temp)에 i값 저장.
        i = j;        // i변수에 j값을 저장.
        j = temp;   // j변수에 임시변수(temp)에 저장되었던 i값을 저장.
        Debug.Log($"변경 i : {i}, j : {j}");

        /*
        [0] ↓ 내가 혼자서 푼 것. ↓
        int i = 100;
        int j = 200;
        Debug.Log("처음 i : " + i + ", j : " + j);

        double a = 100;
        double b = 200;
        a = j;
        b = i;
        Debug.Log("변경 i : " + a + ", j : " + b);
        */
    }
}



/*
 [Q]
    +, -, *, / 등의 연산없이 변수 i, j의 값을 서로 바꾸어 저장하세요.
    = 만 이용하세요.
    temp 변수를 만들어서 이용해보세요.

 [Output]
    처음 i:100, j:200
    변경 i:200, j:100
 */