using UnityEngine;

// 문자열 비교.
public class StringCompair : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 정의 : 만약, s1과 s2가 같으면 Same이라고 출력.
        string s1 = "Hello";
        string s2 = "Hello";
        // [1-1]
        if (s1 == s2)
        {
            Debug.Log("Same");
        }

        // [2] 정의 : 만약, bln 값이 false이면 실행문을 실행.
        bool bln = false;
        // [2-1]
        if (bln == false)
        {
            Debug.Log("bln : " + bln);
        }

        // [3] 정의 : !bln값이 참이면 실행문을 실행.
        // [3-1]
        if (!bln)
        {
            Debug.Log("!bln : " + !bln);
        }
    }

}
