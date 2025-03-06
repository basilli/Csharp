using UnityEngine;

public class IncrementPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Á¤ÀÇ
        int number1 = 3;
        int number2 = 5;
        int result1 = 0;
        int result2 = 0;

        number1--;                            // 2
        result1 = ++number1;               // 3
        Debug.Log("result1 : " + result1);  // 3

        ++number2;                           // 6
        result2 = number2--;                 // 5
        Debug.Log("result2 : " + result2);  // 5
    }
}
