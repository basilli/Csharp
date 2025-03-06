using UnityEngine;

// DecrementOperator(감소 연산자) : 정수형 변수의 값을 1 감소.
public class DecrementOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int num = -100;

        // [2] -1 감소식
        --num; // num -= 1; OR num = num - 1;
        Debug.Log("num : " + num);
    }
    

}
