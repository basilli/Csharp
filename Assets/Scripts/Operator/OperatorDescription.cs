using UnityEngine;

// Operator(연산자) : +, -, *, / 등 사칙연산을 진행하는 키워드.
public class OperatorDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(3 + 5);   // 더하기
        Debug.Log(3 - 5);   // 빼기
        Debug.Log(3 * 5);   // 곱하기
        Debug.Log(3 / 5);   // 나누기
    }
}
