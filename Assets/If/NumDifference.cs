using UnityEngine;

// [0] 개요 : 두개의 정수 차이를 양의 정수로 구하시오.
public class NumDifference : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        int first = -3;
        int second = -8;
        int diff = 0;   // 두 수의 차이값.

        // [2] 가정 : 큰 수 판별식
        if (first >= second)
        {
            diff = first - second;
        }
        else
        {
            diff = second - first;
        }

        // [3] 결과
        Debug.Log($"diff : {diff}");
    }

}
