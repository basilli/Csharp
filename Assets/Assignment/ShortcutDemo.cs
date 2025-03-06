using UnityEngine;

// +=, -=, *=, /=, &= : 누적식, 사칙연산+누적
public class ShortcutDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int a = 3;
        int b = 5;

        // [2] b변수에 a변수의 값을 누적하라.
        b += a; // b = b + a; 와 같음.
        Debug.Log(b);

        // [3] b변수에 a변수의 값을 감산하라.
        b -= a; // b = b - a;와 같음
        Debug.Log(b);

    }
}
