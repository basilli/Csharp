using UnityEngine;

// UnaryOperator(단항연산자) : +, -
public class UnaryOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] int형 변수 value 선언하고 0으로 초기화.
        int value = 0;

        // [2]
        value = 8;  // value 변수에 8이란 값을 저장 → 8.
        value = +value;
        Debug.Log(value); // 8

        // [3]
        value = -8;  // value 변수에 -8이란 값을 저장 → -8.
        value = +value;
        Debug.Log(value); // -8

        // [4]
        value = 8;  // value 변수에 8이란 값을 저장 → 8.
        value = -value;
        Debug.Log(value); // -8

        // [5]
        value = -8;  // value 변수에 -8이란 값을 저장 → -8.
        value = -value;
        Debug.Log(value); // 8
    }
}
