using UnityEngine;

// Integer : 정수형 변수
public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] int형 변수가 가질 수 있는 가장 작은 값
        int min = -2147483648;
        // [2] int형 변수가 가질 수 있는 가장 큰 값
        int max = 2147483647;

        Debug.Log("int 변수의 최솟값" + min);
        Debug.Log("int 변수의 최댓값" + max);
          
    }

}
