using UnityEngine;

public class CharTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의
        char c = 'a';

        // [2] 가정 및 결과 : 대문자 판별식.
        if (c >= 'a' && c <= 'z')
        {
            Debug.Log($"{c}는 대문자 입니다.");
        }
        else
        {
            Debug.Log($"{c}는 소문자 입니다.");
        }
    }
}
