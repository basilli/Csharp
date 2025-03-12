using UnityEngine;


/* [0] 개요 : RandomDemo
		- Random Class : 랜덤값과 관련된 변수나 메서드가 있는 Class.
*/

public class RandomDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1-1] 정의 : 클래스의 객체 생성.
        System.Random random = new System.Random();

        // [2-1] 결과 : 임의의 정수값 구하기.
        Debug.Log(random.Next());
        // [2-2] 결과 : 0~4 중 하나의 값을 구하기.
        Debug.Log(random.Next(5));
        // [2-3] 결과 : 1~9 중 하나의 값을 구하기.
        Debug.Log(random.Next(1, 10));      // ) 조건의 가장 작은 값과 가장 큰 값(원하는 수의 초과)을 입력.
        // [2-4] 결과 : -10~0 중 하나의 값을 구하기.
        Debug.Log(random.Next(-10, 1));
        // [2-5] 결과 : 1.1~1.9 중 하나의 값을 구하기.
        // Debug.Log(random.NextDouble(1.1, 1.9));      // ) NextDouble로 조건을 바꾸고 따로 추가해야함.
    }
}
