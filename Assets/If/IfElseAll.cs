using UnityEngine;


// [0] 개요 : IfElseAll
public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /* [1] 정의
               - 하나의 정수를 입력 받아서 짝수인지 홀수인지 판별할 것.       
         */
        int number = 21;

        // [2-1] 가정 : 짝수 판별식.
        if (number % 2 == 0)
        {
            Debug.Log($"{number}는 짝수입니다. ");
        }

        // [2-2] 가정 : 홀수 판별식.
        if (number % 2 != 0)
        {
            Debug.Log($"{number}는 홀수입니다. ");
        }
        else
        {
            Debug.Log($"{number}는 짝수입니다. ");
        }

        // [2-3] 가정 : 3의 배수, 5의 배수, 7의 배수 판별식.
        if (number % 3 == 0)
        {
            Debug.Log($"{number}는 3의 배수입니다. ");
        }
        else if (number % 5 == 0)
        {
            Debug.Log($"{number}는 5의 배수입니다. ");
        }
        else
        {
            Debug.Log($"{number}는 7의 배수입니다. ");
        }
    }
}
