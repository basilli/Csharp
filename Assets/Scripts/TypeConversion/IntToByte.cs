using UnityEngine;

public class IntToByte : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] x를 int형 변수 x를 선언하고 255로 초기화.
        int x = 255;
        // [2] byte형 변수 y를 선언하고 x의 값으로 초기화.
            // byte의 저장범위 : 0~255.
        byte y = (byte)x;

        Debug.Log(x + " → " + y);

    }
}
